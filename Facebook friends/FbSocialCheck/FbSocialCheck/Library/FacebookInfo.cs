using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbSocialCheck.Library
{
    class FacebookInfo
    {
        int _converCount;
        int _evaluator;
        int _option;
        string _myName;
        dynamic _conversations;

        public FacebookInfo(int pCount, int pEvalutor, int pOption, string pName, dynamic pConversations)
        {
            _converCount = pCount;
            _evaluator = pEvalutor;
            _option = pOption;
            _myName = pName;
            _conversations = pConversations;
        }

        public int getConverCount()
        {
            return _converCount;
        }

        public int getEvaluator()
        {
            return _evaluator;
        }
        public int getOption()
        {
            return _option;
        }

        public string getMyName()
        {
            return _myName;
        }

        public dynamic getConversations()
        {
            return _conversations;
        }

    }
}
