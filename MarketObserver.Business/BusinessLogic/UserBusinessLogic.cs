using MarketViewer.Models;
using MarketViewer.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketObserver.Business
{
    public interface IUserBusinessLogic
    {
        //List<UserDto> GetCandidates(UserSearchParams searchParams);
        //bool SaveCandidate(User candidate);
    }

    public class UserBusinessLogic : IUserBusinessLogic
    {
       
        //private UserService _candidateRepository;

        //public UserBusinessLogic(UserService candidateRepository)
        //{
        //    _candidateRepository = candidateRepository;
        //}

        //public List<UserDto> GetCandidates(UserSearchParams searchParams)
        //{
        //    using (var context = new CandidateDbContext())
        //    {
        //        var candidateDtos = _candidateRepository.GetCandidates(context, searchParams);
        //        return candidateDtos;
        //    }
        
        //}

        //public bool SaveCandidate( User candidate)
        //{
        //    using (var context = new CandidateDbContext())
        //    {
        //        var success = false;
        //        if (candidate != null && !string.IsNullOrEmpty(candidate.FirstName) && !string.IsNullOrEmpty(candidate.LastName) 
        //            && !string.IsNullOrEmpty(candidate.Email) && !string.IsNullOrEmpty(candidate.PhoneNumber) && !string.IsNullOrEmpty(candidate.ZipCode))
        //        {
        //            success = _candidateRepository.SaveCandidates(context, candidate);

        //        }

        //        return success;
        //    }
        //}

            
    }
}
