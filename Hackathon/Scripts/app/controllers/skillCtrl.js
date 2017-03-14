angular.module('hackCtrls').controller('skillCtrl', ['$rootScope', '$scope', 'skillsService', function ($rootScope, $scope, skillsService) {
    var vm = this;
    vm.show = false;
    vm.skills = [];
    vm.currentSkill = {};
    vm.currentSkillIndex = 0;
    vm.model = {};

    vm.yes = function () {
        vm.model.skills.push(vm.currentSkill);
        skillsService.post({ skillId: vm.currentSkill.id, title: vm.currentSkill.name, gotSkill: true });
        vm.showNextSkill();
    }

    vm.showNextSkill = function () {
        vm.currentSkillIndex++;
        if (vm.skills.length === vm.currentSkillIndex) {
            // No more to show.
            $rootScope.$broadcast('showJobMatches', vm.model);
            vm.show = false;
        }
        else {
            vm.currentSkill = vm.skills[vm.currentSkillIndex];
        }
    }

    vm.no = function () {
        skillsService.post({ skillId: vm.currentSkill.id, title: vm.currentSkill.name, gotSkill: false });
        vm.showNextSkill();
    }

    $scope.$on('showSkills',
        function (e, data) {
            vm.show = true;
            skillsService.get(data.job.isco).then(function (result) {
                vm.model = data;
                vm.model.skills = [];
                vm.skills = result.data;
                vm.currentSkill = vm.skills[vm.currentSkillIndex];
            });
        });
}]);