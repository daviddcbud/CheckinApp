


angular.module(myAppName).service('mockSearch', ['$q','$log','$timeout',
function($q,$log,$timeout)
{
    var mockData = [];
    var child = { name: 'Lanie', age: 13, grade: 7 };
    var children = [];
    children.push(child);
    child = { name: 'Leah', age: 10, grade: 3 };
    children.push(child);
    mockData.push({ id: 1, name: 'Freeman, David & Christina', number: 55, children: children });
    child = { name: 'Tiarra', age: 5, grade: 'K4' };
     children = [];
    children.push(child);
    
    mockData.push({ id: 2, name: 'Freeman, John', number: 23, children: children });
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
