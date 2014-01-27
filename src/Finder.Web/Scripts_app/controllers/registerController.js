var registerController = ["$scope", "userService", function($scope, userService) {

    $scope.newuser = {};

    $scope.register = function () {
        userService.registerUser($scope.newuser)
            .then(function () {
                $window.location = "#/";
            },
            function (errorReason) {
                alert(errorReason);
            });
    };

}];