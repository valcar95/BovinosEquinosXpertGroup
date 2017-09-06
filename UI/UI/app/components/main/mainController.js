angular.module('xpertGroup').controller('MainCtrl', ['$scope', 'mainService', 'txtFileService', function ($scope, mainService, txtFileService) {

    $scope.file = null;
    $scope.errorMessage = null;

    $scope.UploadFile = function (e) {
        console.log($scope.file);
        if (!$scope.file) {
            $scope.errorMessage = "Por favor selecciona un archivo";
        }
        else {
            $scope.errorMessage = null;
            var uploadFile = mainService.uploadFile($scope.file);
            uploadFile.success(function (data) {
                txtFileService.arrayToTxtFile("Bovinos", data.bovine);
                txtFileService.arrayToTxtFile("Equinos", data.equine);
            });
            uploadFile.error(function (data, status) {
                
            });
        }
    }
}])