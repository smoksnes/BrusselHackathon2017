angular.module('hackCtrls').controller('jobVacanciesCtrl', ['$rootScope', '$scope', 'jobVacanciesService', function ($rootScope, $scope, jobVacanciesService) {
    var vm = this;
    vm.model = {};
    vm.show = false;
    vm.jobVacancies = [];

    $scope.$on('showJobVacancies',
        function (e, data) {
            debugger;
            vm.model = data;
            vm.show = true;
            jobVacanciesService.post(vm.model).then(function(result) {
                vm.jobVacancies = result.data;
            });
        });
}]);