angular.module('hackCtrls').controller('jobCtrl', ['$rootScope', '$scope', '$timeout', 'occupationService', function ($rootScope, $scope, $timeout, occupationService) {
    var vm = this;
    vm.show = true;
    vm.regions = ['Sweden', 'UK', 'Finland'];
    vm.showJobs = false;
    vm.model =
        {

        };
    vm.selectJob = function (job) {
        vm.model.job = job;
        vm.jobs = [job];
    };
    vm.undoJob = function () {
        vm.model.job = null;
    }

    vm.startFindSkills = function () {
        $rootScope.$broadcast('showSkills', vm.model);
        vm.show = false;
    }

    vm.jobs = [];



    $scope.$watch(function () {
        return vm.model.jobSearch;
    },
        function (newValue, oldValue) {
            console.log('value changed api.');
            vm.model.job = null;
            if (!newValue) {
                newValue = '';
            }
            if (vm.currentSearch) {
                console.log('canceling old query.');
                $timeout.cancel(vm.currentSearch);
            }
            vm.currentSearch = $timeout(function () {
                console.log('calling api.');
                occupationService.get(newValue).then(function (result) {
                    vm.jobs = result.data;
                });
            }, 1000);



        });
}]);