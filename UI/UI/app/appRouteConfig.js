angular.module("xpertGroup").config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "app/components/main/template.html",
        controller: "MainCtrl"
    })
	.otherwise({
	    templateUrl: "app/components/main/template.html",
	    controller: "MainCtrl"
	});
});
