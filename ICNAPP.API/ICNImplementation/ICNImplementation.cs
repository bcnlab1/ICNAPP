using ICNAPP.CSImplementation.Interface;
using ICNAPP.CSImplementation.Operations;
using ICNAPP.Forwarder.Interface;
using ICNAPP.Forwarder.Operations;
using ICNAPP.Models.CustomModels;
using ICNAPP.Models.DatabaseModel;
using ICNAPP.PITEntries.Interface;
using ICNAPP.PITEntries.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICNAPP.API.ICNImplementation
{
    public class ICNImplementation
    {
        private IContentStoreService _contentStoreService;
        private IPITEntriesService _pitService;
        private IFIBEntriesService _fibService;

        public ICNImplementation()
        {
            _contentStoreService = new ContentStoreService();
            _pitService = new PITEntriesService();
            _fibService = new FIBEntriesService();
        }

        public string ProcessInterest(string interestName, string face)
        {
            try
            {
                PITEntry pITEntry = _pitService.GetPITEntryBy(interestName);
                if (pITEntry != null)
                {
                    pITEntry.IncommingFace.Add(face);
                    _pitService.EditPITEntry(pITEntry);
                }
                else // PIT does not exist check content store
                {
                    ContentStore contentStore = _contentStoreService.GetContentStoreBy(interestName);
                    if (contentStore != null)
                    {
                        return contentStore.Content;
                    }
                    else // content is not in CS
                    {
                        FIBEntry fIBEntry = _fibService.GetFIBEntryBy(interestName);
                        ForwardInterest(fIBEntry, interestName);
                    }
                }
                return string.Empty;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ProcessData(string interestName, string data, string face)
        {
            try
            {
                PITEntry pITEntry = _pitService.GetPITEntryBy(interestName);
                if (pITEntry != null)
                {
                    ForwardData(interestName, data, pITEntry);
                }
                else // PIT does not exist - data unsolicited
                {
                    // drop
                }
                return string.Empty;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ForwardData(string interestName, string data, PITEntry pITEntry)
        {
            throw new NotImplementedException();
        }

        private void ForwardInterest(FIBEntry fIBEntry, string interestName)
        {
            throw new NotImplementedException();
        }
    }
}