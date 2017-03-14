angular.module('hackServices').service('jobVacanciesService', ['$http', function ($http) {
    var baseUrl = "/api/jobvacancies/";
    var service = this;
    service.post = function (model) {
        return $http.post(baseUrl, model);
    }
}]);