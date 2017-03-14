angular.module('hackServices').service('jobMatchesService', ['$http', function ($http) {
    var baseUrl = "/api/jobmatches/";
    var service = this;
    service.post = function (model) {
        return $http.post(baseUrl, model);
    }
}]);