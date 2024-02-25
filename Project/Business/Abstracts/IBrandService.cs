using Business.Dtos.Requests;
using Business.Dtos.Responses;

namespace Business.Abstracts;

public interface IBrandService
{
    CreatedBrandResponse Add(CreateBrandRequest brand);
    List<GetAllBrandResponse> GetAll();
    
}
