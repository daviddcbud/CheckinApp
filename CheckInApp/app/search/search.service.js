angular.module(myAppName).service('SearchService', [
	'$q', '$http','$log', function ($q, $http,$log) {

		this.search = function (searchfor) {
			var defer = $q.defer();
			$http.get('/api/family?name=' + searchfor).success(function (data) {
				$log.debug('ok');
				defer.resolve(data);
			}
			).error(function (data) {
				
				defer.reject(data);
			}
			);

			return defer.promise;
		}

	}]
	);