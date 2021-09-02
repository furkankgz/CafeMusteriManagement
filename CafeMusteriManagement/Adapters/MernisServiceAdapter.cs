using System;
using System.Collections.Generic;
using System.Text;
using CafeMusteriManagement.Abstract;
using CafeMusteriManagement.Entities;
using MernisServiceReference;

namespace CafeMusteriManagement.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
            (Convert.ToInt64(customer.NationalityId), customer.FistName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
    }

