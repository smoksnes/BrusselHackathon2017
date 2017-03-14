angular.module('hackCtrls').controller('addSkillsToJobCtrl', ['$rootScope', '$scope', 'skillsService', 'jobVacanciesService', function ($rootScope, $scope, skillsService, jobVacanciesService) {
    var vm = this;
    vm.show = false;
    vm.skills = [];
    vm.currentSkill = {};
    vm.currentSkillIndex = 0;
    vm.model = {};

    vm.yes = function () {
        vm.model.skills.push(vm.currentSkill);
        jobVacanciesService.addSkillToJob(vm.model.id, vm.currentSkill.id);
        vm.showNextSkill();
    }

    vm.showNextSkill = function () {
        vm.currentSkillIndex++;
        if (vm.skills.length === vm.currentSkillIndex) {
            // No more to show.
            $rootScope.$broadcast('showJob', vm.model);
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

    $scope.$on('addSkillsToJob',
        function (e, data) {
            vm.show = true;
            skillsService.get(data.isco).then(function (result) {
                vm.model = data;
                vm.model.skills = [];
                vm.skills = result.data;
                vm.currentSkill = vm.skills[vm.currentSkillIndex];
            });
        });
}]);