angular.module('hackServices').service('occupationService', ['$http', function ($http) {
    var baseUrl = "/api/occupation/";
    var service = this;
    service.get = function (title) {
        var url = baseUrl + title;
        return $http.get(url);
    }
}]);