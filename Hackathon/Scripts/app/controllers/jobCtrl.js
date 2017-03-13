angular.module('hackCtrls').controller('jobCtrl', ['$scope', 'occupationService', function ($scope, occupationService) {
    var vm = this;
    vm.model =
        {

        };
    vm.selectJob = function (job) {
        debugger;
        vm.model.job = job;
        vm.jobs = [job];
    };
    vm.undoJob = function () {
        vm.model.job = null;
    }

    vm.jobs = [];

    $scope.$watch(function() {
            return vm.model.jobSearch;
        },
        function (newValue, oldValue) {
            vm.model.job = null;
            if (!newValue) {
                newValue = '';
            }
            
            occupationService.get(newValue).then(function (result) {
                vm.jobs = result.data;
            });
        });
}]);