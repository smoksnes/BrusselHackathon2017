angular.module('hackCtrls').controller('showJobCtrl', ['$rootScope', '$scope', function ($rootScope, $scope) {
    var vm = this;
    vm.show = false;
    vm.model = {};

    $scope.$on('showJob',
        function (e, data) {
            debugger;
            vm.show = true;
            vm.model = data;
        });
}]);