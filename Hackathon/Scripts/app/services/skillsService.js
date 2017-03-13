angular.module('hackServices').service('skillsService', ['$http', function ($http) {
    var baseUrl = "/api/skills/";
    var service = this;
    service.get = function (jobId) {
        var url = baseUrl + jobId;
        return $http.get(url);
    }
}]);