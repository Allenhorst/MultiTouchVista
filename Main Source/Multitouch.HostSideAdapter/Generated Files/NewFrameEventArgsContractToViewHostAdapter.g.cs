//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3069
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts.HostSideAdapters
{
    
    public class NewFrameEventArgsContractToViewHostAdapter : Multitouch.Contracts.NewFrameEventArgs
    {
        private Multitouch.Contracts.Contracts.INewFrameEventArgsContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static NewFrameEventArgsContractToViewHostAdapter()
        {
        }
        public NewFrameEventArgsContractToViewHostAdapter(Multitouch.Contracts.Contracts.INewFrameEventArgsContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public override System.Collections.Generic.IList<Multitouch.Contracts.IImageData> Images
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIList<Multitouch.Contracts.Contracts.IImageDataContract, Multitouch.Contracts.IImageData>(_contract.Images, Multitouch.Contracts.HostSideAdapters.IImageDataHostAdapter.ContractToViewAdapter, Multitouch.Contracts.HostSideAdapters.IImageDataHostAdapter.ViewToContractAdapter);
            }
        }
        public override System.Collections.Generic.IList<Multitouch.Contracts.IContactData> Contacts
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIList<Multitouch.Contracts.Contracts.IContactDataContract, Multitouch.Contracts.IContactData>(_contract.Contacts, Multitouch.Contracts.HostSideAdapters.IContactDataHostAdapter.ContractToViewAdapter, Multitouch.Contracts.HostSideAdapters.IContactDataHostAdapter.ViewToContractAdapter);
            }
        }
        public override long Timestamp
        {
            get
            {
                return _contract.Timestamp;
            }
        }
        internal Multitouch.Contracts.Contracts.INewFrameEventArgsContract GetSourceContract()
        {
            return _contract;
        }
    }
}

