angular.module(myAppName).service('classMockService', ['$q','$log','$http',
function($q,$log,$http)
{
 
     var mockData=[];
    mockData.push({id:1, name:'1st hour?'});
mockData.push({id:2, name:'2nd hour?'});

     this.getClasses= function()
   {
       var defer=$q.defer();
     

    setTimeout(function(){   
  defer.resolve(mockData);
   },1000);
 
      
     return defer.promise;
};        

}]);
