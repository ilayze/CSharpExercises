using System.Collections.Generic;
using System.Linq;
using StateApp.DAL;
using StateApp.Entities;

namespace StateApp.BL
{
    public class StatesBL
    {

        private readonly StatesDAL _statesRepository;

        public StatesBL(StatesDAL statesRepository)
        {
            _statesRepository = statesRepository;
        }


        public State GetState(string stateName)
        {
            return _statesRepository.GetState(stateName);
        }

        public bool AddState(State s)
        {
            bool isStateExist = IsStateExist(s.StateName);
            if (!isStateExist)
            {
                _statesRepository.AddState(s);
                return true;
            }
            return false;
        }

        public bool IsStateExist(string stateName)
        {
            var stateList = _statesRepository.GetAllStates();
            if (stateList == null)
            {
                return false;
            }
            if (stateList.Any(s => s.StateName == stateName))
                return true;
            return false;
        }

        public LinkedList<State> GetAllStates()
        {
            return _statesRepository.GetAllStates();
        }
    }
}
