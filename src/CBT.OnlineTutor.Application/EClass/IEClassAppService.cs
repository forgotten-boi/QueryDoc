using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CBT.OnlineTutor.EClass.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CBT.OnlineTutor.EClass
{
    public interface IEClassAppService : IApplicationService
    {
        //COMMON METHODS
        Task<ListResultDto<ComboboxItemDto>> GetProgramTypeDDLItems();
        Task<ListResultDto<ComboboxItemDto>> GetUserTypeDDLItems();
        Task<ListResultDto<ComboboxItemDto>> GetCategoryDDLItems();
        Task<ListResultDto<ComboboxItemDto>> GeProgramDDLItems();
        Task<ListResultDto<ComboboxItemDto>> GetCBTContentDDLItems();
        List<ComboboxItemDto> GetCBTContentDDLItemsByCategoryId(int CategoryID);

        //PROGRAM METHODS
        Task<ListResultDto<ProgramListDto>> GetProgramList(GetProgramListInput input);
        Task Create(CreateProgramInput input);
        Task Delete(int id);
        void Update(UpdateProgramInput input);
        ProgramListDto GetProgramById(int programId);
        //ProgramTypeDto GetProgramTypeById(int pTypeId);
        //UserTypeDto GetUserTypeById(int uTypeId);

        //CATEGORY METHODS
        Task<ListResultDto<CategoryDto>> GetCategoryList(GetCategoryListInput input);
        Task CreateCategory(CreateCategoryInput input);
        Task DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryInput input);
        CategoryDto GetCategoryById(int categoryId);
        Task<ListResultDto<CategoryDto>> GetCategoryListByProgramId(GetCategoryListInput input);

        //CBTCONTENT METHODS
        Task<ListResultDto<CBTContentDto>> GetCBTContentList(GetCBTContentListInput input);

        //Task CreateCBTContent(CreateCBTContentInput input);
        Task CreateCBTContent(string input);
        void UpdateCBTContent(UpdateCBTContentInput input);
        Task DeleteCBTContent(int id);
        CBTContentDto GetCBTContentById(int cbtContentId);
        Task<List<CBTContentDto>> GetCBTContentByCategoryId(int catId);

        //CBTCONTENTOPTIONS METHODS
        Task<ListResultDto<CBTContentOptionsDto>> GetCBTContentOptionsList();
    }
}
