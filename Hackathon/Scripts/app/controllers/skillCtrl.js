angular.module('hackCtrls').controller('skillCtrl', ['$rootScope', '$scope', 'skillsService', function ($rootScope, $scope, skillsService) {
    var vm = this;
    vm.show = false;
    vm.skills = [];
    vm.currentSkill = {};
    vm.currentSkillIndex = 0;
    vm.model = {};

    vm.yes = function () {
        vm.model.skills.push(vm.currentSkill);
        vm.showNextSkill();
    }

    vm.showNextSkill = function () {
        vm.currentSkillIndex++;
        if (vm.skills.length === vm.currentSkillIndex) {
            // No more to show.
            $rootScope.$broadcast('showJobVacancies', vm.model);
            vm.show = false;
        }
        else {
            vm.currentSkill = vm.skills[vm.currentSkillIndex];
        }
    }

    vm.no = function () {
        vm.showNextSkill();
    }

    $scope.$on('showSkills',
        function (e, data) {
            vm.show = true;
            skillsService.get(data.job.id).then(function (result) {
                vm.model = result;
                vm.model.skills = [];
                vm.skills = result.data;
                vm.currentSkill = vm.skills[vm.currentSkillIndex];
            });
        });
}]);