angular.module("xpertGroup").factory('mainService', ['$http', 'appConstants', function ($http, appConstants) {
    var uploadFile = function (file) {
        var formdata = new FormData();
        angular.forEach(file, function (value, key) {
            formdata.append(key, value);
        });
        var apiUrl = appConstants.apiUrl + "fileUpload/upload"
        var request = $http({
            method: "POST",
            url: apiUrl,
            data: formdata,
            headers: {
                'Content-Type': undefined
            }
        });
        return request;
    };
   
    return {
        uploadFile: uploadFile
    }
}]);