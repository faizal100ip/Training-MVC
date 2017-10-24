using System;
using System.Collections.Generic;

namespace Training.MVC.Factory
{
    public interface IFactoryApi
    {
        void GetAPI<T>(T vm, string apiResource);

        T GetAPISingle<T>(string apiResource);

        TReturn GetAPISingle<TReturn, TRequest>(TRequest vm, string apiResource);

        T GetAPISingle<T>(string name, string value, string apiResource);

        List<TReturn> GetAPIList<TReturn, TRequest>(TRequest vm, string apiResource);

        List<T> GetAPIList<T>(string apiResource);

        List<T> GetAPIList<T>(T vm, string apiResource);
        
        void PostAPI<T>(T vm, string apiResource);

        string PostAPISingle<T>(string apiResource);

        T PostAPISingle<T>(T vm, string apiResource);

        T PostAPISingle<T>(dynamic vm, string apiResource);

        List<T> PostAPIList<T>(string apiResource);

        List<T> PostAPIList<T>(T vm, string apiResource);

        TReturn PostAPISingle<TReturn, TRequest>(TRequest vm, string apiResource);

        List<TResult> PostAPIList<TResult, TRequest>(TRequest vm, string apiResource);
        
    }
}
