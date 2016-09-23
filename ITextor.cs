using System.Runtime.Serialization;
using System.ServiceModel;

namespace Textor
{
    public enum SortOption
    {
        IgnoreCase

    }

    [ServiceContract]
    public interface ITextor
    {

        [OperationContract]
        string Sort(string text, SortOption sortOption);

        [OperationContract]
        TextStatistics Statistics(string text);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class TextStatistics
    {
        private uint _hyphensCount = 0;
        private uint _spacesCount = 0;
        private uint _wordsCount = 0;

        [DataMember]
        public uint HyphensCount
        {
            get { return _hyphensCount; }
            set { _hyphensCount = value; }
        }

        [DataMember]
        public uint SpacesCount
        {
            get { return _spacesCount; }
            set { _spacesCount = value; }
        }

        [DataMember]
        public uint WordsCount
        {
            get { return _wordsCount; }
            set { _wordsCount = value; }
        }
    }
}
