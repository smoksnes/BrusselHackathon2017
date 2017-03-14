angular.module('hackServices').service('jobVacanciesService', ['$http', function ($http) {
    var baseUrl = "/api/jobvacancies/";
    var service = this;
    service.post = function (model) {
        return $http.post(baseUrl, model);
    }
    service.addSkillToJob = function (jobId, skillId) {
        var url = baseUrl + jobId + '/' + skillId;
        return $http.post(url);
    }
}]);