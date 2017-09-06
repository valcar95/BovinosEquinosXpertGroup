angular.module('xpertGroup', ['ngMaterial', "ngRoute"]);
angular.module('xpertGroup').config(["$httpProvider", function ($httpProvider) {
    var interceptor = function ($q) {
        return {
            responseError: function (rejectian) {
                if (rejectian.status === 404) {
                    alert('error 404');
                    return $q.reject(rejectian);
                }
                if (rejectian.status === 403) {
                    alert('error 403');
                    return $q.reject(rejectian);
                }
                return $q.reject(rejectian);
            }
        }
    }
    var params = ['$q']
    interceptor.$inject = params;
    $httpProvider.interceptors.push(interceptor);
}]);