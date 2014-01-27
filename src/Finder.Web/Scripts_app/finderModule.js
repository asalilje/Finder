var finderModule = angular.module('finder', ['ngRoute']).config(['$routeProvider',
    function ($routeProvider) {

        $routeProvider
            .when('/',
                {
                    templateUrl: '/Templates/Home.html',
                    controller: 'homeController'
                })
            .when('/register',
                {
                    templateUrl: '/Templates/Register.html',
                    controller: 'registerController'
                });

        $routeProvider.otherwise({ redirectTo: "/" });

    }]);