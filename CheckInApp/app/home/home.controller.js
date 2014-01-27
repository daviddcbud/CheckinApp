angular.module(myAppName).controller('HomeCtrl', ['$scope', '$log','SearchService',
    function ($scope, $log, SearchService) {

        $log.debug('Main controller');
        $scope.model = {};
        $scope.model.testing = '1123';

        SearchService.search('freeman').success = function (data) {
            $log.debug(data);
            $scope.model.searchresults = data;
        };



         




    }

]);