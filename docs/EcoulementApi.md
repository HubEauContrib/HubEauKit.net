# HubEauKit.Api.EcoulementApi

All URIs are relative to *https://hubeau.eaufrance.fr/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetChroniqueCsv**](EcoulementApi.md#getchroniquecsv) | **GET** /vbeta/ecoulement/stations.csv | Lister les stations au format CSV |
| [**GetChroniqueCsv1**](EcoulementApi.md#getchroniquecsv1) | **GET** /vbeta/ecoulement/observations.csv | Lister les observations au format CSV |
| [**GetChroniqueCsv2**](EcoulementApi.md#getchroniquecsv2) | **GET** /vbeta/ecoulement/campagnes.csv | Lister les campagnes au format CSV |
| [**GetCommunes**](EcoulementApi.md#getcommunes) | **GET** /vbeta/ecoulement/campagnes | Lister les campagnes |
| [**GetResultats**](EcoulementApi.md#getresultats) | **GET** /vbeta/ecoulement/stations | Lister les stations |
| [**GetResultats1**](EcoulementApi.md#getresultats1) | **GET** /vbeta/ecoulement/observations | Lister les observations |

<a name="getchroniquecsv"></a>
# **GetChroniqueCsv**
> Station GetChroniqueCsv (List<string>? codeStation = null, List<string>? libelleStation = null, List<string>? codeDepartement = null, List<string>? libelleDepartement = null, List<string>? codeCommune = null, List<string>? libelleCommune = null, List<string>? codeRegion = null, List<string>? libelleRegion = null, List<string>? codeBassin = null, List<string>? libelleBassin = null, List<string>? codeCoursEau = null, List<string>? libelleCoursEau = null, double? longitude = null, double? latitude = null, double? distance = null, List<double>? bbox = null, string? sort = null, int? numroDeLaPage = null, int? size = null, string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null)

Lister les stations au format CSV

Lister les stations au format CSV

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubEauKit.Api;
using HubEauKit.Client;
using HubEauKit.Model;

namespace Example
{
    public class GetChroniqueCsvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://hubeau.eaufrance.fr/api";
            var apiInstance = new EcoulementApi(config);
            var codeStation = new List<string>?(); // List<string>? | Code(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&VERSION=1.1.0&REQUEST=GetFeature&typename=StationHydro_FXX&SRSNAME=EPSG:2154&OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleStation = new List<string>?(); // List<string>? | Libellé(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&VERSION=1.1.0&REQUEST=GetFeature&typename=StationHydro_FXX&SRSNAME=EPSG:2154&OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeDepartement = new List<string>?(); // List<string>? | Code(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleDepartement = new List<string>?(); // List<string>? | Libellé(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeCommune = new List<string>?(); // List<string>? | Code(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleCommune = new List<string>?(); // List<string>? | Libellé(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeRegion = new List<string>?(); // List<string>? | Code(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleRegion = new List<string>?(); // List<string>? | Libellé(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeBassin = new List<string>?(); // List<string>? | Code(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 (optional) 
            var libelleBassin = new List<string>?(); // List<string>? | Libellé(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 (optional) 
            var codeCoursEau = new List<string>?(); // List<string>? | Code(s) Sandre du cours d'eau associé à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleCoursEau = new List<string>?(); // List<string>? | Libellé(s) Sandre du cours d'eau associée à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var longitude = 1.2D;  // double? | Longitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 1.937 (optional) 
            var latitude = 1.2D;  // double? | Latitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 47.829 (optional) 
            var distance = 1.2D;  // double? | Rayon de recherche en kilomètre, le point doit être utilisé comme séparateur décimal, exemple : 30 (optional) 
            var bbox = new List<double>?(); // List<double>? | Rectangle d'emprise de l'objet demandé, emprise au format : min longitude, min latitude, max longitude, max latitude avec les coordonnées en WGS84 (EPSG:4326), le point doit être utilisé comme séparateur décimal, exemple : 1.6194,47.7965,2.1910,47.9988 (optional) 
            var sort = "asc";  // string? |  (optional) 
            var numroDeLaPage = 56;  // int? |  (optional) 
            var size = 20;  // int? |  (optional)  (default to 20)
            var listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = "listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation_example";  // string? |  (optional) 

            try
            {
                // Lister les stations au format CSV
                Station result = apiInstance.GetChroniqueCsv(codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, longitude, latitude, distance, bbox, sort, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EcoulementApi.GetChroniqueCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChroniqueCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lister les stations au format CSV
    ApiResponse<Station> response = apiInstance.GetChroniqueCsvWithHttpInfo(codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, longitude, latitude, distance, bbox, sort, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EcoulementApi.GetChroniqueCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeStation** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE&#x3D;WFS&amp;VERSION&#x3D;1.1.0&amp;REQUEST&#x3D;GetFeature&amp;typename&#x3D;StationHydro_FXX&amp;SRSNAME&#x3D;EPSG:2154&amp;OUTPUTFORMAT&#x3D;GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleStation** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE&#x3D;WFS&amp;VERSION&#x3D;1.1.0&amp;REQUEST&#x3D;GetFeature&amp;typename&#x3D;StationHydro_FXX&amp;SRSNAME&#x3D;EPSG:2154&amp;OUTPUTFORMAT&#x3D;GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeDepartement** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleDepartement** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeCommune** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleCommune** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeRegion** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleRegion** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeBassin** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 | [optional]  |
| **libelleBassin** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 | [optional]  |
| **codeCoursEau** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre du cours d&#39;eau associé à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleCoursEau** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre du cours d&#39;eau associée à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **longitude** | **double?** | Longitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 1.937 | [optional]  |
| **latitude** | **double?** | Latitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 47.829 | [optional]  |
| **distance** | **double?** | Rayon de recherche en kilomètre, le point doit être utilisé comme séparateur décimal, exemple : 30 | [optional]  |
| **bbox** | [**List&lt;double&gt;?**](double.md) | Rectangle d&#39;emprise de l&#39;objet demandé, emprise au format : min longitude, min latitude, max longitude, max latitude avec les coordonnées en WGS84 (EPSG:4326), le point doit être utilisé comme séparateur décimal, exemple : 1.6194,47.7965,2.1910,47.9988 | [optional]  |
| **sort** | **string?** |  | [optional]  |
| **numroDeLaPage** | **int?** |  | [optional]  |
| **size** | **int?** |  | [optional] [default to 20] |
| **listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation** | **string?** |  | [optional]  |

### Return type

[**Station**](Station.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **206** | OK, il reste des résultats |  -  |
| **400** | Requête incorrecte |  -  |
| **500** | Erreur interne du serveur |  -  |
| **200** | OK, tous les résultats sont présents dans la réponse |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchroniquecsv1"></a>
# **GetChroniqueCsv1**
> Observation GetChroniqueCsv1 (List<string>? codeStation = null, List<string>? libelleStation = null, List<string>? codeDepartement = null, List<string>? libelleDepartement = null, List<string>? codeCommune = null, List<string>? libelleCommune = null, List<string>? codeRegion = null, List<string>? libelleRegion = null, List<string>? codeBassin = null, List<string>? libelleBassin = null, List<string>? codeCoursEau = null, List<string>? libelleCoursEau = null, List<string>? codeCampagne = null, List<string>? codeReseau = null, List<string>? libelleReseau = null, DateTime? dateObservationMin = null, DateTime? dateObservationMax = null, List<string>? codeEcoulement = null, List<string>? libelleEcoulement = null, double? longitude = null, double? latitude = null, double? distance = null, List<double>? bbox = null, int? numroDeLaPage = null, int? size = null, string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null)

Lister les observations au format CSV

Lister les observations au format CSV

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubEauKit.Api;
using HubEauKit.Client;
using HubEauKit.Model;

namespace Example
{
    public class GetChroniqueCsv1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://hubeau.eaufrance.fr/api";
            var apiInstance = new EcoulementApi(config);
            var codeStation = new List<string>?(); // List<string>? | Code(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&VERSION=1.1.0&REQUEST=GetFeature&typename=StationHydro_FXX&SRSNAME=EPSG:2154&OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleStation = new List<string>?(); // List<string>? | Libellé(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&VERSION=1.1.0&REQUEST=GetFeature&typename=StationHydro_FXX&SRSNAME=EPSG:2154&OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeDepartement = new List<string>?(); // List<string>? | Code(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleDepartement = new List<string>?(); // List<string>? | Libellé(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeCommune = new List<string>?(); // List<string>? | Code(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleCommune = new List<string>?(); // List<string>? | Libellé(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeRegion = new List<string>?(); // List<string>? | Code(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleRegion = new List<string>?(); // List<string>? | Libellé(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeBassin = new List<string>?(); // List<string>? | Code(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 (optional) 
            var libelleBassin = new List<string>?(); // List<string>? | Libellé(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 (optional) 
            var codeCoursEau = new List<string>?(); // List<string>? | Code(s) Sandre du cours d'eau associé à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleCoursEau = new List<string>?(); // List<string>? | Libellé(s) Sandre du cours d'eau associée à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeCampagne = new List<string>?(); // List<string>? | Code(s) Onde de la campagne d'observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeReseau = new List<string>?(); // List<string>? | Code(s) Sandre du réseau associé à la campagne d'observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleReseau = new List<string>?(); // List<string>? | Libellé(s) Sandre du réseau associé à la campagne d'observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var dateObservationMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date minimale de l'observation (format YYYY-MM-DD) : renvoie les observations pour lesquelles date_observation >= date_observation_min (optional) 
            var dateObservationMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date maximale de l'observation (format YYYY-MM-DD) : renvoie les observations pour lesquelles date_observation <= date_observation_max (optional) 
            var codeEcoulement = new List<string>?(); // List<string>? | Code(s) de la modalité d'écoulement. Valeurs possibles : 1 / 1a / 1f /  2 / 3 / 4. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 5 (optional) 
            var libelleEcoulement = new List<string>?(); // List<string>? | Libellé de la modalité d'écoulement. Valeurs possibles : Ecoulement visible / Ecoulement visible acceptable / Ecoulement visible faible / Ecoulement non visible / Assec / Observation impossible. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 5 (optional) 
            var longitude = 1.2D;  // double? | Longitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 1.937 (optional) 
            var latitude = 1.2D;  // double? | Latitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 47.829 (optional) 
            var distance = 1.2D;  // double? | Rayon de recherche en kilomètre, le point doit être utilisé comme séparateur décimal, exemple : 30 (optional) 
            var bbox = new List<double>?(); // List<double>? | Rectangle d'emprise de l'objet demandé, emprise au format : min longitude, min latitude, max longitude, max latitude avec les coordonnées en WGS84 (EPSG:4326), le point doit être utilisé comme séparateur décimal, exemple : 1.6194,47.7965,2.1910,47.9988 (optional) 
            var numroDeLaPage = 56;  // int? |  (optional) 
            var size = 20;  // int? |  (optional)  (default to 20)
            var listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = "listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation_example";  // string? |  (optional) 

            try
            {
                // Lister les observations au format CSV
                Observation result = apiInstance.GetChroniqueCsv1(codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, codeCampagne, codeReseau, libelleReseau, dateObservationMin, dateObservationMax, codeEcoulement, libelleEcoulement, longitude, latitude, distance, bbox, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EcoulementApi.GetChroniqueCsv1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChroniqueCsv1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lister les observations au format CSV
    ApiResponse<Observation> response = apiInstance.GetChroniqueCsv1WithHttpInfo(codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, codeCampagne, codeReseau, libelleReseau, dateObservationMin, dateObservationMax, codeEcoulement, libelleEcoulement, longitude, latitude, distance, bbox, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EcoulementApi.GetChroniqueCsv1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeStation** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE&#x3D;WFS&amp;VERSION&#x3D;1.1.0&amp;REQUEST&#x3D;GetFeature&amp;typename&#x3D;StationHydro_FXX&amp;SRSNAME&#x3D;EPSG:2154&amp;OUTPUTFORMAT&#x3D;GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleStation** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE&#x3D;WFS&amp;VERSION&#x3D;1.1.0&amp;REQUEST&#x3D;GetFeature&amp;typename&#x3D;StationHydro_FXX&amp;SRSNAME&#x3D;EPSG:2154&amp;OUTPUTFORMAT&#x3D;GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeDepartement** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleDepartement** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeCommune** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleCommune** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeRegion** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleRegion** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeBassin** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 | [optional]  |
| **libelleBassin** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 | [optional]  |
| **codeCoursEau** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre du cours d&#39;eau associé à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleCoursEau** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre du cours d&#39;eau associée à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeCampagne** | [**List&lt;string&gt;?**](string.md) | Code(s) Onde de la campagne d&#39;observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeReseau** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre du réseau associé à la campagne d&#39;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleReseau** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre du réseau associé à la campagne d&#39;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **dateObservationMin** | **DateTime?** | Date minimale de l&#39;observation (format YYYY-MM-DD) : renvoie les observations pour lesquelles date_observation &gt;&#x3D; date_observation_min | [optional]  |
| **dateObservationMax** | **DateTime?** | Date maximale de l&#39;observation (format YYYY-MM-DD) : renvoie les observations pour lesquelles date_observation &lt;&#x3D; date_observation_max | [optional]  |
| **codeEcoulement** | [**List&lt;string&gt;?**](string.md) | Code(s) de la modalité d&#39;écoulement. Valeurs possibles : 1 / 1a / 1f /  2 / 3 / 4. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 5 | [optional]  |
| **libelleEcoulement** | [**List&lt;string&gt;?**](string.md) | Libellé de la modalité d&#39;écoulement. Valeurs possibles : Ecoulement visible / Ecoulement visible acceptable / Ecoulement visible faible / Ecoulement non visible / Assec / Observation impossible. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 5 | [optional]  |
| **longitude** | **double?** | Longitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 1.937 | [optional]  |
| **latitude** | **double?** | Latitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 47.829 | [optional]  |
| **distance** | **double?** | Rayon de recherche en kilomètre, le point doit être utilisé comme séparateur décimal, exemple : 30 | [optional]  |
| **bbox** | [**List&lt;double&gt;?**](double.md) | Rectangle d&#39;emprise de l&#39;objet demandé, emprise au format : min longitude, min latitude, max longitude, max latitude avec les coordonnées en WGS84 (EPSG:4326), le point doit être utilisé comme séparateur décimal, exemple : 1.6194,47.7965,2.1910,47.9988 | [optional]  |
| **numroDeLaPage** | **int?** |  | [optional]  |
| **size** | **int?** |  | [optional] [default to 20] |
| **listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation** | **string?** |  | [optional]  |

### Return type

[**Observation**](Observation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK, tous les résultats sont présents dans la réponse |  -  |
| **206** | OK, il reste des résultats |  -  |
| **400** | Requête incorrecte |  -  |
| **500** | Erreur interne du serveur |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchroniquecsv2"></a>
# **GetChroniqueCsv2**
> Campagne GetChroniqueCsv2 (List<int>? codeCampagne = null, DateTime? dateCampagneMin = null, DateTime? dateCampagneMax = null, List<int>? codeTypeCampagne = null, List<string>? libelleTypeCampagne = null, List<string>? codeReseau = null, List<string>? libelleReseau = null, List<string>? codeDepartement = null, List<string>? libelleDepartement = null, int? numroDeLaPage = null, int? size = null, string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null)

Lister les campagnes au format CSV

Lister les campagnes au format CSV

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubEauKit.Api;
using HubEauKit.Client;
using HubEauKit.Model;

namespace Example
{
    public class GetChroniqueCsv2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://hubeau.eaufrance.fr/api";
            var apiInstance = new EcoulementApi(config);
            var codeCampagne = new List<int>?(); // List<int>? | Code(s) Onde de la campagne. Identfiant numérique auto incrémenté non signifiant, si plusieurs codes les séparer par une virgule, nombre maximum de codes = 20 (optional) 
            var dateCampagneMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date minimale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne >= date_campagne_min (optional) 
            var dateCampagneMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date maximale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne <= date_campagne_max (optional) 
            var codeTypeCampagne = new List<int>?(); // List<int>? | Code du type de campagne d'observation. Valeurs possibles : 1 / 2 (optional) 
            var libelleTypeCampagne = new List<string>?(); // List<string>? | Type de campagne d'observation. Valeurs possibles : Usuelle / Complémentaire (optional) 
            var codeReseau = new List<string>?(); // List<string>? | Code(s) Sandre du réseau associé à la campagne d'observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleReseau = new List<string>?(); // List<string>? | Libellé(s) Sandre du réseau associé à la campagne d'observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeDepartement = new List<string>?(); // List<string>? | Code(s) INSEE du département associé à la campagne d'observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleDepartement = new List<string>?(); // List<string>? | Libellé(s) INSEE du département associé à la campagne d'observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var numroDeLaPage = 56;  // int? |  (optional) 
            var size = 20;  // int? |  (optional)  (default to 20)
            var listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = "listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation_example";  // string? |  (optional) 

            try
            {
                // Lister les campagnes au format CSV
                Campagne result = apiInstance.GetChroniqueCsv2(codeCampagne, dateCampagneMin, dateCampagneMax, codeTypeCampagne, libelleTypeCampagne, codeReseau, libelleReseau, codeDepartement, libelleDepartement, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EcoulementApi.GetChroniqueCsv2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChroniqueCsv2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lister les campagnes au format CSV
    ApiResponse<Campagne> response = apiInstance.GetChroniqueCsv2WithHttpInfo(codeCampagne, dateCampagneMin, dateCampagneMax, codeTypeCampagne, libelleTypeCampagne, codeReseau, libelleReseau, codeDepartement, libelleDepartement, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EcoulementApi.GetChroniqueCsv2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeCampagne** | [**List&lt;int&gt;?**](int.md) | Code(s) Onde de la campagne. Identfiant numérique auto incrémenté non signifiant, si plusieurs codes les séparer par une virgule, nombre maximum de codes &#x3D; 20 | [optional]  |
| **dateCampagneMin** | **DateTime?** | Date minimale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne &gt;&#x3D; date_campagne_min | [optional]  |
| **dateCampagneMax** | **DateTime?** | Date maximale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne &lt;&#x3D; date_campagne_max | [optional]  |
| **codeTypeCampagne** | [**List&lt;int&gt;?**](int.md) | Code du type de campagne d&#39;observation. Valeurs possibles : 1 / 2 | [optional]  |
| **libelleTypeCampagne** | [**List&lt;string&gt;?**](string.md) | Type de campagne d&#39;observation. Valeurs possibles : Usuelle / Complémentaire | [optional]  |
| **codeReseau** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre du réseau associé à la campagne d&#39;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleReseau** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre du réseau associé à la campagne d&#39;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeDepartement** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE du département associé à la campagne d&#39;observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleDepartement** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE du département associé à la campagne d&#39;observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **numroDeLaPage** | **int?** |  | [optional]  |
| **size** | **int?** |  | [optional] [default to 20] |
| **listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation** | **string?** |  | [optional]  |

### Return type

[**Campagne**](Campagne.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **206** | OK, il reste des résultats |  -  |
| **400** | Requête incorrecte |  -  |
| **500** | Erreur interne du serveur |  -  |
| **200** | OK, tous les résultats sont présents dans la réponse |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommunes"></a>
# **GetCommunes**
> CampagneResult GetCommunes (List<int>? codeCampagne = null, DateTime? dateCampagneMin = null, DateTime? dateCampagneMax = null, List<int>? codeTypeCampagne = null, List<string>? libelleTypeCampagne = null, List<string>? codeReseau = null, List<string>? libelleReseau = null, List<string>? codeDepartement = null, List<string>? libelleDepartement = null, int? numroDeLaPage = null, int? size = null, string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null, string? accept = null)

Lister les campagnes

Lister les campagnes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubEauKit.Api;
using HubEauKit.Client;
using HubEauKit.Model;

namespace Example
{
    public class GetCommunesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://hubeau.eaufrance.fr/api";
            var apiInstance = new EcoulementApi(config);
            var codeCampagne = new List<int>?(); // List<int>? | Code(s) Onde de la campagne. Identfiant numérique auto incrémenté non signifiant, si plusieurs codes les séparer par une virgule, nombre maximum de codes = 20 (optional) 
            var dateCampagneMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date minimale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne >= date_campagne_min (optional) 
            var dateCampagneMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date maximale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne <= date_campagne_max (optional) 
            var codeTypeCampagne = new List<int>?(); // List<int>? | Code du type de campagne d'observation. Valeurs possibles : 1 / 2 (optional) 
            var libelleTypeCampagne = new List<string>?(); // List<string>? | Type de campagne d'observation. Valeurs possibles : Usuelle / Complémentaire (optional) 
            var codeReseau = new List<string>?(); // List<string>? | Code(s) Sandre du réseau associé à la campagne d'observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleReseau = new List<string>?(); // List<string>? | Libellé(s) Sandre du réseau associé à la campagne d'observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeDepartement = new List<string>?(); // List<string>? | Code(s) INSEE du département associé à la campagne d'observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleDepartement = new List<string>?(); // List<string>? | Libellé(s) INSEE du département associé à la campagne d'observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var numroDeLaPage = 56;  // int? |  (optional) 
            var size = 20;  // int? |  (optional)  (default to 20)
            var listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = "listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation_example";  // string? |  (optional) 
            var accept = "accept_example";  // string? |  (optional) 

            try
            {
                // Lister les campagnes
                CampagneResult result = apiInstance.GetCommunes(codeCampagne, dateCampagneMin, dateCampagneMax, codeTypeCampagne, libelleTypeCampagne, codeReseau, libelleReseau, codeDepartement, libelleDepartement, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EcoulementApi.GetCommunes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommunesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lister les campagnes
    ApiResponse<CampagneResult> response = apiInstance.GetCommunesWithHttpInfo(codeCampagne, dateCampagneMin, dateCampagneMax, codeTypeCampagne, libelleTypeCampagne, codeReseau, libelleReseau, codeDepartement, libelleDepartement, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EcoulementApi.GetCommunesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codeCampagne** | [**List&lt;int&gt;?**](int.md) | Code(s) Onde de la campagne. Identfiant numérique auto incrémenté non signifiant, si plusieurs codes les séparer par une virgule, nombre maximum de codes &#x3D; 20 | [optional]  |
| **dateCampagneMin** | **DateTime?** | Date minimale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne &gt;&#x3D; date_campagne_min | [optional]  |
| **dateCampagneMax** | **DateTime?** | Date maximale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne &lt;&#x3D; date_campagne_max | [optional]  |
| **codeTypeCampagne** | [**List&lt;int&gt;?**](int.md) | Code du type de campagne d&#39;observation. Valeurs possibles : 1 / 2 | [optional]  |
| **libelleTypeCampagne** | [**List&lt;string&gt;?**](string.md) | Type de campagne d&#39;observation. Valeurs possibles : Usuelle / Complémentaire | [optional]  |
| **codeReseau** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre du réseau associé à la campagne d&#39;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleReseau** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre du réseau associé à la campagne d&#39;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeDepartement** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE du département associé à la campagne d&#39;observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleDepartement** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE du département associé à la campagne d&#39;observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **numroDeLaPage** | **int?** |  | [optional]  |
| **size** | **int?** |  | [optional] [default to 20] |
| **listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation** | **string?** |  | [optional]  |
| **accept** | **string?** |  | [optional]  |

### Return type

[**CampagneResult**](CampagneResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/javascript;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **206** | OK, il reste des résultats |  -  |
| **400** | Requête incorrecte |  -  |
| **500** | Erreur interne du serveur |  -  |
| **200** | OK, tous les résultats sont présents dans la réponse |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresultats"></a>
# **GetResultats**
> StationResult GetResultats (string? format = null, List<string>? codeStation = null, List<string>? libelleStation = null, List<string>? codeDepartement = null, List<string>? libelleDepartement = null, List<string>? codeCommune = null, List<string>? libelleCommune = null, List<string>? codeRegion = null, List<string>? libelleRegion = null, List<string>? codeBassin = null, List<string>? libelleBassin = null, List<string>? codeCoursEau = null, List<string>? libelleCoursEau = null, double? longitude = null, double? latitude = null, double? distance = null, List<double>? bbox = null, string? sort = null, int? numroDeLaPage = null, int? size = null, string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null, string? accept = null)

Lister les stations

Lister les stations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubEauKit.Api;
using HubEauKit.Client;
using HubEauKit.Model;

namespace Example
{
    public class GetResultatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://hubeau.eaufrance.fr/api";
            var apiInstance = new EcoulementApi(config);
            var format = "json";  // string? |  (optional)  (default to json)
            var codeStation = new List<string>?(); // List<string>? | Code(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&VERSION=1.1.0&REQUEST=GetFeature&typename=StationHydro_FXX&SRSNAME=EPSG:2154&OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleStation = new List<string>?(); // List<string>? | Libellé(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&VERSION=1.1.0&REQUEST=GetFeature&typename=StationHydro_FXX&SRSNAME=EPSG:2154&OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeDepartement = new List<string>?(); // List<string>? | Code(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleDepartement = new List<string>?(); // List<string>? | Libellé(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeCommune = new List<string>?(); // List<string>? | Code(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleCommune = new List<string>?(); // List<string>? | Libellé(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeRegion = new List<string>?(); // List<string>? | Code(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleRegion = new List<string>?(); // List<string>? | Libellé(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeBassin = new List<string>?(); // List<string>? | Code(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 (optional) 
            var libelleBassin = new List<string>?(); // List<string>? | Libellé(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 (optional) 
            var codeCoursEau = new List<string>?(); // List<string>? | Code(s) Sandre du cours d'eau associé à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleCoursEau = new List<string>?(); // List<string>? | Libellé(s) Sandre du cours d'eau associée à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var longitude = 1.2D;  // double? | Longitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 1.937 (optional) 
            var latitude = 1.2D;  // double? | Latitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 47.829 (optional) 
            var distance = 1.2D;  // double? | Rayon de recherche en kilomètre, le point doit être utilisé comme séparateur décimal, exemple : 30 (optional) 
            var bbox = new List<double>?(); // List<double>? | Rectangle d'emprise de l'objet demandé, emprise au format : min longitude, min latitude, max longitude, max latitude avec les coordonnées en WGS84 (EPSG:4326), le point doit être utilisé comme séparateur décimal, exemple : 1.6194,47.7965,2.1910,47.9988 (optional) 
            var sort = "asc";  // string? |  (optional) 
            var numroDeLaPage = 56;  // int? |  (optional) 
            var size = 20;  // int? |  (optional)  (default to 20)
            var listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = "listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation_example";  // string? |  (optional) 
            var accept = "accept_example";  // string? |  (optional) 

            try
            {
                // Lister les stations
                StationResult result = apiInstance.GetResultats(format, codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, longitude, latitude, distance, bbox, sort, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EcoulementApi.GetResultats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResultatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lister les stations
    ApiResponse<StationResult> response = apiInstance.GetResultatsWithHttpInfo(format, codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, longitude, latitude, distance, bbox, sort, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EcoulementApi.GetResultatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** |  | [optional] [default to json] |
| **codeStation** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE&#x3D;WFS&amp;VERSION&#x3D;1.1.0&amp;REQUEST&#x3D;GetFeature&amp;typename&#x3D;StationHydro_FXX&amp;SRSNAME&#x3D;EPSG:2154&amp;OUTPUTFORMAT&#x3D;GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleStation** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE&#x3D;WFS&amp;VERSION&#x3D;1.1.0&amp;REQUEST&#x3D;GetFeature&amp;typename&#x3D;StationHydro_FXX&amp;SRSNAME&#x3D;EPSG:2154&amp;OUTPUTFORMAT&#x3D;GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeDepartement** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleDepartement** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeCommune** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleCommune** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeRegion** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleRegion** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeBassin** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 | [optional]  |
| **libelleBassin** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 | [optional]  |
| **codeCoursEau** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre du cours d&#39;eau associé à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleCoursEau** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre du cours d&#39;eau associée à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **longitude** | **double?** | Longitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 1.937 | [optional]  |
| **latitude** | **double?** | Latitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 47.829 | [optional]  |
| **distance** | **double?** | Rayon de recherche en kilomètre, le point doit être utilisé comme séparateur décimal, exemple : 30 | [optional]  |
| **bbox** | [**List&lt;double&gt;?**](double.md) | Rectangle d&#39;emprise de l&#39;objet demandé, emprise au format : min longitude, min latitude, max longitude, max latitude avec les coordonnées en WGS84 (EPSG:4326), le point doit être utilisé comme séparateur décimal, exemple : 1.6194,47.7965,2.1910,47.9988 | [optional]  |
| **sort** | **string?** |  | [optional]  |
| **numroDeLaPage** | **int?** |  | [optional]  |
| **size** | **int?** |  | [optional] [default to 20] |
| **listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation** | **string?** |  | [optional]  |
| **accept** | **string?** |  | [optional]  |

### Return type

[**StationResult**](StationResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.geo+json, application/javascript;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **206** | OK, il reste des résultats |  -  |
| **400** | Requête incorrecte |  -  |
| **500** | Erreur interne du serveur |  -  |
| **200** | OK, tous les résultats sont présents dans la réponse |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresultats1"></a>
# **GetResultats1**
> ObservationResult GetResultats1 (string? format = null, List<string>? codeStation = null, List<string>? libelleStation = null, List<string>? codeDepartement = null, List<string>? libelleDepartement = null, List<string>? codeCommune = null, List<string>? libelleCommune = null, List<string>? codeRegion = null, List<string>? libelleRegion = null, List<string>? codeBassin = null, List<string>? libelleBassin = null, List<string>? codeCoursEau = null, List<string>? libelleCoursEau = null, List<string>? codeCampagne = null, List<string>? codeReseau = null, List<string>? libelleReseau = null, DateTime? dateObservationMin = null, DateTime? dateObservationMax = null, List<string>? codeEcoulement = null, List<string>? libelleEcoulement = null, double? longitude = null, double? latitude = null, double? distance = null, List<double>? bbox = null, int? numroDeLaPage = null, int? size = null, string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null, string? accept = null)

Lister les observations

Lister les observations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HubEauKit.Api;
using HubEauKit.Client;
using HubEauKit.Model;

namespace Example
{
    public class GetResultats1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://hubeau.eaufrance.fr/api";
            var apiInstance = new EcoulementApi(config);
            var format = "json";  // string? |  (optional)  (default to json)
            var codeStation = new List<string>?(); // List<string>? | Code(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&VERSION=1.1.0&REQUEST=GetFeature&typename=StationHydro_FXX&SRSNAME=EPSG:2154&OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleStation = new List<string>?(); // List<string>? | Libellé(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&VERSION=1.1.0&REQUEST=GetFeature&typename=StationHydro_FXX&SRSNAME=EPSG:2154&OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeDepartement = new List<string>?(); // List<string>? | Code(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleDepartement = new List<string>?(); // List<string>? | Libellé(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeCommune = new List<string>?(); // List<string>? | Code(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleCommune = new List<string>?(); // List<string>? | Libellé(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeRegion = new List<string>?(); // List<string>? | Code(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleRegion = new List<string>?(); // List<string>? | Libellé(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeBassin = new List<string>?(); // List<string>? | Code(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 (optional) 
            var libelleBassin = new List<string>?(); // List<string>? | Libellé(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 (optional) 
            var codeCoursEau = new List<string>?(); // List<string>? | Code(s) Sandre du cours d'eau associé à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleCoursEau = new List<string>?(); // List<string>? | Libellé(s) Sandre du cours d'eau associée à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeCampagne = new List<string>?(); // List<string>? | Code(s) Onde de la campagne d'observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var codeReseau = new List<string>?(); // List<string>? | Code(s) Sandre du réseau associé à la campagne d'observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var libelleReseau = new List<string>?(); // List<string>? | Libellé(s) Sandre du réseau associé à la campagne d'observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 (optional) 
            var dateObservationMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date minimale de l'observation (format YYYY-MM-DD) : renvoie les observations pour lesquelles date_observation >= date_observation_min (optional) 
            var dateObservationMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date maximale de l'observation (format YYYY-MM-DD) : renvoie les observations pour lesquelles date_observation <= date_observation_max (optional) 
            var codeEcoulement = new List<string>?(); // List<string>? | Code(s) de la modalité d'écoulement. Valeurs possibles : 1 / 1a / 1f /  2 / 3 / 4. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 5 (optional) 
            var libelleEcoulement = new List<string>?(); // List<string>? | Libellé de la modalité d'écoulement. Valeurs possibles : Ecoulement visible / Ecoulement visible acceptable / Ecoulement visible faible / Ecoulement non visible / Assec / Observation impossible. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 5 (optional) 
            var longitude = 1.2D;  // double? | Longitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 1.937 (optional) 
            var latitude = 1.2D;  // double? | Latitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 47.829 (optional) 
            var distance = 1.2D;  // double? | Rayon de recherche en kilomètre, le point doit être utilisé comme séparateur décimal, exemple : 30 (optional) 
            var bbox = new List<double>?(); // List<double>? | Rectangle d'emprise de l'objet demandé, emprise au format : min longitude, min latitude, max longitude, max latitude avec les coordonnées en WGS84 (EPSG:4326), le point doit être utilisé comme séparateur décimal, exemple : 1.6194,47.7965,2.1910,47.9988 (optional) 
            var numroDeLaPage = 56;  // int? |  (optional) 
            var size = 20;  // int? |  (optional)  (default to 20)
            var listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = "listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation_example";  // string? |  (optional) 
            var accept = "accept_example";  // string? |  (optional) 

            try
            {
                // Lister les observations
                ObservationResult result = apiInstance.GetResultats1(format, codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, codeCampagne, codeReseau, libelleReseau, dateObservationMin, dateObservationMax, codeEcoulement, libelleEcoulement, longitude, latitude, distance, bbox, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation, accept);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EcoulementApi.GetResultats1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResultats1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lister les observations
    ApiResponse<ObservationResult> response = apiInstance.GetResultats1WithHttpInfo(format, codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, codeCampagne, codeReseau, libelleReseau, dateObservationMin, dateObservationMax, codeEcoulement, libelleEcoulement, longitude, latitude, distance, bbox, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation, accept);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EcoulementApi.GetResultats1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** |  | [optional] [default to json] |
| **codeStation** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE&#x3D;WFS&amp;VERSION&#x3D;1.1.0&amp;REQUEST&#x3D;GetFeature&amp;typename&#x3D;StationHydro_FXX&amp;SRSNAME&#x3D;EPSG:2154&amp;OUTPUTFORMAT&#x3D;GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleStation** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE&#x3D;WFS&amp;VERSION&#x3D;1.1.0&amp;REQUEST&#x3D;GetFeature&amp;typename&#x3D;StationHydro_FXX&amp;SRSNAME&#x3D;EPSG:2154&amp;OUTPUTFORMAT&#x3D;GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeDepartement** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleDepartement** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeCommune** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleCommune** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeRegion** | [**List&lt;string&gt;?**](string.md) | Code(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleRegion** | [**List&lt;string&gt;?**](string.md) | Libellé(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeBassin** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 | [optional]  |
| **libelleBassin** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15 | [optional]  |
| **codeCoursEau** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre du cours d&#39;eau associé à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleCoursEau** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre du cours d&#39;eau associée à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeCampagne** | [**List&lt;string&gt;?**](string.md) | Code(s) Onde de la campagne d&#39;observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **codeReseau** | [**List&lt;string&gt;?**](string.md) | Code(s) Sandre du réseau associé à la campagne d&#39;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **libelleReseau** | [**List&lt;string&gt;?**](string.md) | Libellé(s) Sandre du réseau associé à la campagne d&#39;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200 | [optional]  |
| **dateObservationMin** | **DateTime?** | Date minimale de l&#39;observation (format YYYY-MM-DD) : renvoie les observations pour lesquelles date_observation &gt;&#x3D; date_observation_min | [optional]  |
| **dateObservationMax** | **DateTime?** | Date maximale de l&#39;observation (format YYYY-MM-DD) : renvoie les observations pour lesquelles date_observation &lt;&#x3D; date_observation_max | [optional]  |
| **codeEcoulement** | [**List&lt;string&gt;?**](string.md) | Code(s) de la modalité d&#39;écoulement. Valeurs possibles : 1 / 1a / 1f /  2 / 3 / 4. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 5 | [optional]  |
| **libelleEcoulement** | [**List&lt;string&gt;?**](string.md) | Libellé de la modalité d&#39;écoulement. Valeurs possibles : Ecoulement visible / Ecoulement visible acceptable / Ecoulement visible faible / Ecoulement non visible / Assec / Observation impossible. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 5 | [optional]  |
| **longitude** | **double?** | Longitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 1.937 | [optional]  |
| **latitude** | **double?** | Latitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 47.829 | [optional]  |
| **distance** | **double?** | Rayon de recherche en kilomètre, le point doit être utilisé comme séparateur décimal, exemple : 30 | [optional]  |
| **bbox** | [**List&lt;double&gt;?**](double.md) | Rectangle d&#39;emprise de l&#39;objet demandé, emprise au format : min longitude, min latitude, max longitude, max latitude avec les coordonnées en WGS84 (EPSG:4326), le point doit être utilisé comme séparateur décimal, exemple : 1.6194,47.7965,2.1910,47.9988 | [optional]  |
| **numroDeLaPage** | **int?** |  | [optional]  |
| **size** | **int?** |  | [optional] [default to 20] |
| **listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation** | **string?** |  | [optional]  |
| **accept** | **string?** |  | [optional]  |

### Return type

[**ObservationResult**](ObservationResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.geo+json, application/javascript;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **206** | OK, il reste des résultats |  -  |
| **400** | Requête incorrecte |  -  |
| **500** | Erreur interne du serveur |  -  |
| **200** | OK, tous les résultats sont présents dans la réponse |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

