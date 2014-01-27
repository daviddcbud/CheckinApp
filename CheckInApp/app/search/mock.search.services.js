


angular.module(myAppName).service('mockSearch', ['$q','$log','$timeout',
function($q,$log,$timeout)
{
   var mockData=[];
   mockData.push({id:1,name:'Freeman, David & Christina'});
   this.search=function(searchfor)
{
$log.debug('searching..');
     var defer=$q.defer();
     
     var data=mockData;
     
    setTimeout(function(){   
 $log.debug('resolving');
 defer.resolve(data);},1000);
 
     return defer.promise;
};
}]);
