angular.module(myAppName).controller('HomeCtrl', ['$scope', '$log', 'SearchService',
'mockSearch', '$timeout','sharedDataService','classMockService',
    function ($scope, $log, SearchService, mockSearch, $timeout,sharedDataService,
classMockService) {

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

        $scope.model.classes=[];
        var searchService = mockSearch;
        var classService=classMockService;

        $scope.search = function () {
            $scope.model.searchResults = [];
            searchService.search($scope.model.searchData).then(function (data) {
                $scope.model.classes=classService.getClasses();
                $scope.model.searchResults = data;

            }, function(e)  {
                 sharedDataService.setAlert('Error');
                  
});

        };







    }

]);
