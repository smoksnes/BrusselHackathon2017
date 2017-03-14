angular.module('hackCtrls').controller('createJobCtrl', ['$rootScope', '$scope', '$timeout', 'occupationService', 'jobVacanciesService', function ($rootScope, $scope, $timeout, occupationService, jobVacanciesService) {
    var vm = this;
    vm.show = false;
    vm.searching = false;
    vm.model = {};

    $scope.$on('createJob', function (e, data) {
        vm.show = true;
    });

    vm.selectJob = function (job) {
        vm.model.job = job;
        vm.model.isco = job.isco;
        vm.jobs = [job];
        vm.model.jobSearch = '';
    };
    vm.undoJob = function () {
        vm.model.job = null;
        vm.model.isco = null;
    }

    vm.createJob = function() {
        jobVacanciesService.post(vm.model).then(function(result) {
            debugger;
        });
    }

    vm.jobs = [];

    $scope.$watch(function () {
        return vm.model.jobSearch;
    },
        function (newValue, oldValue) {
            console.log('value changed api.');
            vm.model.job = null;
            if (!newValue || newValue === '') {
                return;
            }
            vm.searching = true;
            if (vm.currentSearch) {
                console.log('canceling old query.');
                $timeout.cancel(vm.currentSearch);
            }
            vm.currentSearch = $timeout(function () {
                console.log('calling api.');
                occupationService.get(newValue).then(function (result) {
                    vm.jobs = result.data;
                    vm.searching = false;
                });
            }, 1000);



        });
}]);