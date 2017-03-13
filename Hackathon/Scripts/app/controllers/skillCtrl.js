angular.module('hackCtrls').controller('skillCtrl', ['$rootScope', '$scope', 'skillsService', function ($rootScope, $scope, skillsService) {
    var vm = this;
    vm.show = false;
    vm.skills = [];
    vm.currentSkill = {};
    vm.currentSkillIndex = 0;

    vm.yes = function () {
        vm.currentSkillIndex++;
        vm.currentSkill = vm.skills[vm.currentSkillIndex];
    }

    vm.no = function() {
        
    }

    $scope.$on('userSettingsSaved',
        function (e, data) {
            vm.show = true;
            skillsService.get(data.job.id).then(function(result) {
                debugger;
                vm.skills = result.data;
                vm.currentSkill = vm.skills[vm.currentSkillIndex];
            });
        });
}]);