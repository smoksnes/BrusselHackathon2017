angular.module('hackCtrls').controller('summaryCtrl', ['$rootScope', '$scope', function ($rootScope, $scope) {
    var vm = this;
    vm.show = false;
    $scope.$on('showSummary',
        function (e, data) {
            vm.show = true;
        });
}]);