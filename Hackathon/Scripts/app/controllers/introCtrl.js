angular.module('hackCtrls').controller('introCtrl', ['$rootScope', '$scope', '$timeout', 'occupationService', function ($rootScope, $scope, $timeout, occupationService) {
    var vm = this;
    vm.show = true;
    vm.findAJob = function () {
        $rootScope.$broadcast('findJob');
        vm.show = false;
    }
    vm.findAEmployee = function () {
        $rootScope.$broadcast('createJob');
        vm.show = false;
    }
}]);