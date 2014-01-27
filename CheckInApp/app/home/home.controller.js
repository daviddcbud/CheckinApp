angular.module(myAppName).controller('HomeCtrl', ['$scope', '$log','SearchService',
'mockSearch',
    function ($scope, $log, SearchService,mockSearch) {

        $log.debug('Main controller');
        $scope.model = {};
        $scope.model.searchData='';
$scope.model.searchResults=[];
      
      var searchService=mockSearch;
     
$scope.search= function() 
{
        $scope.model.searchResults=[];
        searchService.search($scope.model.searchData).then(function (data) {
            $log.debug('got results');
            $scope.model.searchResults = data;
            
        });

};


         




    }

]);
