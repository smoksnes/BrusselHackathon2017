angular.module('hackCtrls').controller('showJobMatchesCtrl', ['$rootScope', '$scope', 'jobMatchesService', function ($rootScope, $scope, jobMatchesService) {
    var vm = this;
    vm.model = {};
    vm.show = false;
    vm.matches = [];

    $scope.$on('showJobMatches',
        function (e, data) {
            vm.model = {
                isco: data.job.isco,
                skills: []
            };
            angular.forEach(data.skills,
                function (value, index) {
                    vm.model.skills.push(value.id);
                });
            vm.show = true;

            jobMatchesService.post(vm.model).then(function(result) {
                vm.matches = result.data;
            });
        });
}]);