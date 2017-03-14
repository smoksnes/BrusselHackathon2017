angular.module('hackCtrls').controller('createJobCtrl', ['$rootScope', '$scope', '$timeout', 'occupationService', function ($rootScope, $scope, $timeout, occupationService) {
    var vm = this;
    vm.show = false;
    $scope.$on('createJob', function (e, data) {
        vm.show = true;
    });
}]);