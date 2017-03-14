angular.module('hackCtrls').controller('jobVacanciesCtrl', ['$rootScope', '$scope', 'jobMatchesService', function ($rootScope, $scope, jobMatchesService) {
    var vm = this;
    vm.model = {};
    vm.show = false;
    vm.jobVacancies = [];

    $scope.$on('showJobVacancies',
        function (e, data) {
            vm.model = data;
            vm.show = true;
            jobMatchesService.post(vm.model).then(function(result) {
                vm.jobVacancies = result.data;
            });
        });
}]);