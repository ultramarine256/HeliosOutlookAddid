using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Helios.Api.Domain.Entities.PluginModule.Helios;
using Helios.Api.Utils.Api.Helios;

namespace Helios.Tests.Synchronization.Data
{
    class FakeHeliosApi : IHeliosApi
    {
        public Task<string> UpdateRefreshToken()
        {
            return null;
        }

        public Task<string> RetrieveEvents()
        {
            return null;
        }

        public Task<string> UpdateEvents(IList<HeliosEvent> heliosEvents)
        {
            return null;
        }

        public Task<string> CreateTask(HeliosTaskToCreate task)
        {
            throw new NotImplementedException();
        }

        public Task<IList<HeliosTask>> RetrieveTasks()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateTask(HeliosTaskToUpdate task)
        {
            throw new NotImplementedException();
        }

        public Task<string> AcceptTask(string taskId, string apiKey)
        {
            throw new NotImplementedException();
        }

        public Task<string> CompleteTask(string taskId, string apiKey)
        {
            throw new NotImplementedException();
        }

        public Task<string> RejectTask(string taskId, string apiKey)
        {
            throw new NotImplementedException();
        }

        Task<IList<HeliosEvent>> IHeliosApi.RetrieveEvents()
        {
            throw new NotImplementedException();
        }

        void IHeliosApi.CompleteTask(string taskId, string apiKey)
        {
            throw new NotImplementedException();
        }

        void IHeliosApi.RejectTask(string taskId, string apiKey)
        {
            throw new NotImplementedException();
        }
    }
}