angular.module(myAppName).controller('HomeCtrl', ['$scope', '$log', 'SearchService',
'mockSearch', '$timeout',
    function ($scope, $log, SearchService, mockSearch, $timeout) {

       // $scope.$parent.shellmodel.alert = 'from index';

        $log.debug('Main controller');
        $scope.model = {};
        $scope.model.searchData = '';
        $scope.model.searchResults = [];

        var timeout;
        $scope.$watch('model.searchData', function (newVal) {
            if (newVal) {
                if (timeout) $timeout.cancel(timeout);
                timeout = $timeout(function () {
                    $scope.search();
                }, 350);
            }
        });

        var searchService = SearchService;

        $scope.search = function () {
            $scope.model.searchResults = [];
            searchService.search($scope.model.searchData).then(function (data) {
                $log.debug('got results');
                $scope.model.searchResults = data;

            });

        };







    }

]);
