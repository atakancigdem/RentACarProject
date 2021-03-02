using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Security.JWT.Concrete;

namespace Core.Utilities.Security.JWT.Abstract
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}