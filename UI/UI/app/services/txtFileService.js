angular.module("xpertGroup").factory('txtFileService', [function () {
    var arrayToTxtFile = function (name,data) {
        var link = document.createElement('a');
        mimeType ='text/plain';
        link.setAttribute('download', name+".txt");
        link.setAttribute('href', 'data:' + mimeType + ';charset=utf-8,' + encodeURIComponent(data.toString()));
        link.click();
    }
    

    return {
        arrayToTxtFile: arrayToTxtFile
    }
}]);