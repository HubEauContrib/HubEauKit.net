/*
 * API Hub'Eau - Ecoulement des cours d'eau
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: vbeta
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using HubEauKit.Client;
using HubEauKit.Api;
// uncomment below to import models
//using HubEauKit.Model;

namespace HubEauKit.Test.Api
{
    /// <summary>
    ///  Class for testing EcoulementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EcoulementApiTests : IDisposable
    {
        private EcoulementApi instance;

        public EcoulementApiTests()
        {
            instance = new EcoulementApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EcoulementApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EcoulementApi
            //Assert.IsType<EcoulementApi>(instance);
        }

        /// <summary>
        /// Test GetChroniqueCsv
        /// </summary>
        [Fact]
        public void GetChroniqueCsvTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? codeStation = null;
            //List<string>? libelleStation = null;
            //List<string>? codeDepartement = null;
            //List<string>? libelleDepartement = null;
            //List<string>? codeCommune = null;
            //List<string>? libelleCommune = null;
            //List<string>? codeRegion = null;
            //List<string>? libelleRegion = null;
            //List<string>? codeBassin = null;
            //List<string>? libelleBassin = null;
            //List<string>? codeCoursEau = null;
            //List<string>? libelleCoursEau = null;
            //double? longitude = null;
            //double? latitude = null;
            //double? distance = null;
            //List<double>? bbox = null;
            //string? sort = null;
            //int? numroDeLaPage = null;
            //int? size = null;
            //string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null;
            //var response = instance.GetChroniqueCsv(codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, longitude, latitude, distance, bbox, sort, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation);
            //Assert.IsType<Station>(response);
        }

        /// <summary>
        /// Test GetChroniqueCsv1
        /// </summary>
        [Fact]
        public void GetChroniqueCsv1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? codeStation = null;
            //List<string>? libelleStation = null;
            //List<string>? codeDepartement = null;
            //List<string>? libelleDepartement = null;
            //List<string>? codeCommune = null;
            //List<string>? libelleCommune = null;
            //List<string>? codeRegion = null;
            //List<string>? libelleRegion = null;
            //List<string>? codeBassin = null;
            //List<string>? libelleBassin = null;
            //List<string>? codeCoursEau = null;
            //List<string>? libelleCoursEau = null;
            //List<string>? codeCampagne = null;
            //List<string>? codeReseau = null;
            //List<string>? libelleReseau = null;
            //DateTime? dateObservationMin = null;
            //DateTime? dateObservationMax = null;
            //List<string>? codeEcoulement = null;
            //List<string>? libelleEcoulement = null;
            //double? longitude = null;
            //double? latitude = null;
            //double? distance = null;
            //List<double>? bbox = null;
            //int? numroDeLaPage = null;
            //int? size = null;
            //string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null;
            //var response = instance.GetChroniqueCsv1(codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, codeCampagne, codeReseau, libelleReseau, dateObservationMin, dateObservationMax, codeEcoulement, libelleEcoulement, longitude, latitude, distance, bbox, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation);
            //Assert.IsType<Observation>(response);
        }

        /// <summary>
        /// Test GetChroniqueCsv2
        /// </summary>
        [Fact]
        public void GetChroniqueCsv2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int>? codeCampagne = null;
            //DateTime? dateCampagneMin = null;
            //DateTime? dateCampagneMax = null;
            //List<int>? codeTypeCampagne = null;
            //List<string>? libelleTypeCampagne = null;
            //List<string>? codeReseau = null;
            //List<string>? libelleReseau = null;
            //List<string>? codeDepartement = null;
            //List<string>? libelleDepartement = null;
            //int? numroDeLaPage = null;
            //int? size = null;
            //string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null;
            //var response = instance.GetChroniqueCsv2(codeCampagne, dateCampagneMin, dateCampagneMax, codeTypeCampagne, libelleTypeCampagne, codeReseau, libelleReseau, codeDepartement, libelleDepartement, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation);
            //Assert.IsType<Campagne>(response);
        }

        /// <summary>
        /// Test GetCommunes
        /// </summary>
        [Fact]
        public void GetCommunesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int>? codeCampagne = null;
            //DateTime? dateCampagneMin = null;
            //DateTime? dateCampagneMax = null;
            //List<int>? codeTypeCampagne = null;
            //List<string>? libelleTypeCampagne = null;
            //List<string>? codeReseau = null;
            //List<string>? libelleReseau = null;
            //List<string>? codeDepartement = null;
            //List<string>? libelleDepartement = null;
            //int? numroDeLaPage = null;
            //int? size = null;
            //string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null;
            //string? accept = null;
            //var response = instance.GetCommunes(codeCampagne, dateCampagneMin, dateCampagneMax, codeTypeCampagne, libelleTypeCampagne, codeReseau, libelleReseau, codeDepartement, libelleDepartement, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation, accept);
            //Assert.IsType<CampagneResult>(response);
        }

        /// <summary>
        /// Test GetResultats
        /// </summary>
        [Fact]
        public void GetResultatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? format = null;
            //List<string>? codeStation = null;
            //List<string>? libelleStation = null;
            //List<string>? codeDepartement = null;
            //List<string>? libelleDepartement = null;
            //List<string>? codeCommune = null;
            //List<string>? libelleCommune = null;
            //List<string>? codeRegion = null;
            //List<string>? libelleRegion = null;
            //List<string>? codeBassin = null;
            //List<string>? libelleBassin = null;
            //List<string>? codeCoursEau = null;
            //List<string>? libelleCoursEau = null;
            //double? longitude = null;
            //double? latitude = null;
            //double? distance = null;
            //List<double>? bbox = null;
            //string? sort = null;
            //int? numroDeLaPage = null;
            //int? size = null;
            //string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null;
            //string? accept = null;
            //var response = instance.GetResultats(format, codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, longitude, latitude, distance, bbox, sort, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation, accept);
            //Assert.IsType<StationResult>(response);
        }

        /// <summary>
        /// Test GetResultats1
        /// </summary>
        [Fact]
        public void GetResultats1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? format = null;
            //List<string>? codeStation = null;
            //List<string>? libelleStation = null;
            //List<string>? codeDepartement = null;
            //List<string>? libelleDepartement = null;
            //List<string>? codeCommune = null;
            //List<string>? libelleCommune = null;
            //List<string>? codeRegion = null;
            //List<string>? libelleRegion = null;
            //List<string>? codeBassin = null;
            //List<string>? libelleBassin = null;
            //List<string>? codeCoursEau = null;
            //List<string>? libelleCoursEau = null;
            //List<string>? codeCampagne = null;
            //List<string>? codeReseau = null;
            //List<string>? libelleReseau = null;
            //DateTime? dateObservationMin = null;
            //DateTime? dateObservationMax = null;
            //List<string>? codeEcoulement = null;
            //List<string>? libelleEcoulement = null;
            //double? longitude = null;
            //double? latitude = null;
            //double? distance = null;
            //List<double>? bbox = null;
            //int? numroDeLaPage = null;
            //int? size = null;
            //string? listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation = null;
            //string? accept = null;
            //var response = instance.GetResultats1(format, codeStation, libelleStation, codeDepartement, libelleDepartement, codeCommune, libelleCommune, codeRegion, libelleRegion, codeBassin, libelleBassin, codeCoursEau, libelleCoursEau, codeCampagne, codeReseau, libelleReseau, dateObservationMin, dateObservationMax, codeEcoulement, libelleEcoulement, longitude, latitude, distance, bbox, numroDeLaPage, size, listeDesChampsSouhaitsDansLaRponseFonctionnalitExprimentaleParExempleFieldscodeStationlocalisation, accept);
            //Assert.IsType<ObservationResult>(response);
        }
    }
}
