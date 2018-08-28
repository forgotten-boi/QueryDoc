using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using CBT.OnlineTutor.EClass.Dtos;
using CBT.OnlineTutor.User;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using CBT.OnlineTutor.ContentType;

namespace CBT.OnlineTutor.EClass
{
    public class EClassAppService : OnlineTutorAppServiceBase, IEClassAppService
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<CBTContent> _cbtContentRepository;
        private readonly IRepository<ProgramList> _programListRepository;
        private readonly IRepository<ProgramType> _programTypeRepository;
        private readonly IRepository<UserType> _userTypeRepository;
        private readonly IRepository<CBTContentOptions> _cbtContentOptionsRepository;
        private readonly IRepository<ContentTypes> _contentTypeRepository;

        public EClassAppService(IRepository<Category> categoryRepository, IRepository<CBTContent> cbtContentRepository, IRepository<ProgramList> programListRepository,
            IRepository<ProgramType> programTypeRepository, IRepository<UserType> userTypeRepository, IRepository<CBTContentOptions> cbtContentOptionsRepository, IRepository<ContentTypes> contentTypeRepository)
        {
            _categoryRepository = categoryRepository;
            _cbtContentRepository = cbtContentRepository;
            _programListRepository = programListRepository;
            _programTypeRepository = programTypeRepository;
            _userTypeRepository = userTypeRepository;
            _cbtContentOptionsRepository = cbtContentOptionsRepository;
            _contentTypeRepository = contentTypeRepository;
        }

        public async Task<ListResultDto<ProgramListDto>> GetProgramList(GetProgramListInput input)
        {
            var programList = await _programListRepository
                            .GetAll()
                            .Include(t => t.UType)
                            .Include(p => p.PType)
                            .ToListAsync();
            var programType = await _programTypeRepository.GetAllListAsync();
            var userType = await _userTypeRepository.GetAllListAsync();

            var pList = from pl in programList
                        join pt in programType on pl.ProgramTypeId equals pt.Id
                        join ut in userType on pl.UserTypeId equals ut.Id
                        select new ProgramListDto
                        {
                            ProgramId = pl.Id,
                            UniqueId = pl.UniqueId,
                            Name = pl.Name.Substring(0, pl.Name.Length > 20 ? 20 : pl.Name.Length) + (pl.Name.Length > 20 ? "..." : ""),
                            Description = pl.Description,
                            Status = pl.Status,
                            ProgramCount = pl.ProgramCount,
                            ProgramLastDate = pl.ProgramLastDate,
                            UserTypeId = pl.UserTypeId,
                            UserTypeName = ut.Name,
                            ProgramTypeId = pl.ProgramTypeId,
                            ProgramName = pt.Name,
                            Feedback = pl.Feedback
                        };

            return new ListResultDto<ProgramListDto>(
                ObjectMapper.Map<List<ProgramListDto>>(pList)
            );
        }

        public async Task Create(CreateProgramInput input)
        {
            var pList = ObjectMapper.Map<ProgramList>(input);
            await _programListRepository.InsertAsync(pList);
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetProgramTypeDDLItems()
        {
            var programType = await _programTypeRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                programType.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Name)).ToList()
            );
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetUserTypeDDLItems()
        {
            var userType = await _userTypeRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                userType.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Name)).ToList()
            );
        }

        public async Task Delete(int id)
        {
            var programList = await _programListRepository
                            .GetAll()
                            .Where(p => p.Id == id)
                            .ToListAsync();
            //var pList = ObjectMapper.Map<ProgramList>(programList);
            if (programList.Count > 0)
            {
                await _programListRepository.DeleteAsync(programList.FirstOrDefault());
            }

            //var List = await _programListRepository
            //                .GetAll()
            //                .Include(t => t.UType)
            //                .Include(p => p.PType)
            //                .ToListAsync();

            //return new ListResultDto<ProgramListDto>(
            //    ObjectMapper.Map<List<ProgramListDto>>(List)
            //);
        }

        public void Update(UpdateProgramInput input)
        {
            //var pList = ObjectMapper.Map<ProgramList>(input);
            //await _programListRepository.UpdateAsync(pList);
            var pList = _programListRepository.Get(input.ProgramId);
            pList.UniqueId = input.UniqueId;
            pList.Name = input.Name;
            pList.Description = input.Description;
            pList.Status = input.Status;
            pList.ProgramLastDate = input.ProgramLastDate;
            pList.UType = _userTypeRepository.Load(input.UserTypeId);
            pList.PType = _programTypeRepository.Load(input.ProgramTypeId);
        }

        public ProgramListDto GetProgramById(int programId)
        {
            var programList = _programListRepository
                                    .GetAll()
                                    .Include(t => t.UType)
                                    .Include(p => p.PType)
                                    .Where(p => p.Id == programId).FirstOrDefault();
            var pList = ObjectMapper.Map<ProgramListDto>(programList);
            return pList;
        }

        //public ProgramTypeDto GetProgramTypeById(int pTypeId)
        //{
        //    var programType = _programTypeRepository
        //                            .GetAll()
        //                            .Where(p => p.Id == pTypeId).FirstOrDefault();
        //    var pType = ObjectMapper.Map<ProgramTypeDto>(programType);
        //    return pType;
        //}

        //public UserTypeDto GetUserTypeById(int uTypeId)
        //{
        //    var userType = _programTypeRepository
        //                            .GetAll()
        //                            .Where(p => p.Id == uTypeId).FirstOrDefault();
        //    var uType = ObjectMapper.Map<UserTypeDto>(userType);
        //    return uType;
        //}

        public async Task<ListResultDto<CategoryDto>> GetCategoryList(GetCategoryListInput input)
        {
            var categoryList = await _categoryRepository
                            .GetAll()
                            .Include(t => t.PList)
                            .Include(t => t.CBTContents)
                            .ToListAsync();

            var programList = await _programListRepository.GetAllListAsync();

            var cList = from cl in categoryList
                        join pl in programList on cl.ProgramListId equals pl.Id
                        join pcl in categoryList on cl.ParentId equals pcl.Id into pclE
                        from pcl in pclE.DefaultIfEmpty()
                        select new CategoryDto
                        {
                            CategoryId = cl.Id,
                            CategoryName = cl.CategoryName.Substring(0, cl.CategoryName.Length > 20 ? 20 : cl.CategoryName.Length) + (cl.CategoryName.Length > 20 ? "..." : ""),
                            Description = cl.Description.Substring(0, cl.Description.Length > 20 ? 20 : cl.Description.Length) + (cl.Description.Length > 20 ? "..." : ""),
                            ParentId = pcl?.Id,
                            ParentCategoryName = pcl?.CategoryName,
                            ProgramListId = cl.ProgramListId,
                            ProgramCode = pl.UniqueId
                        };

            return new ListResultDto<CategoryDto>(
                ObjectMapper.Map<List<CategoryDto>>(cList)
            );
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetCategoryDDLItems()
        {
            var categoryList = await _categoryRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                categoryList.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.CategoryName.Substring(0, p.CategoryName.Length > 50 ? 50 : p.CategoryName.Length) + (p.CategoryName.Length > 50 ? "..." : ""))).ToList()
            );
        }

        public async Task<ListResultDto<ComboboxItemDto>> GeProgramDDLItems()
        {
            var programList = await _programListRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                programList.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Name)).ToList()
            );
        }

        public async Task CreateCategory(CreateCategoryInput input)
        {
            var cList = ObjectMapper.Map<Category>(input);
            await _categoryRepository.InsertAsync(cList);
        }

        public async Task DeleteCategory(int id)
        {
            var cList = await _categoryRepository
                            .GetAll()
                            .Where(p => p.Id == id)
                            .ToListAsync();

            if (cList.Count > 0)
            {
                await _categoryRepository.DeleteAsync(cList.FirstOrDefault());
            }
        }

        public void UpdateCategory(UpdateCategoryInput input)
        {
            var cList = _categoryRepository.Get(input.CategoryId);
            cList.CategoryName = input.CategoryName;
            cList.Description = input.Description;
            cList.ParentId = input.ParentId;
            cList.PList = _programListRepository.Load(input.ProgramListId);
        }

        public CategoryDto GetCategoryById(int categoryId)
        {
            var category = _categoryRepository
                                    .GetAll()
                                    .Include(p => p.PList)
                                    .Where(p => p.Id == categoryId).FirstOrDefault();
            var cList = ObjectMapper.Map<CategoryDto>(category);
            return cList;
        }
        public async Task<ListResultDto<CBTContentDto>> GetCBTContentList(GetCBTContentListInput input)
        {
            var cbtContentList = await _cbtContentRepository
                            .GetAll()
                            .Include(t => t.Categories)
                            .Include(t => t.ContentType)
                            .Include(c => c.CBTContentOption)
                            .ToListAsync();

            var categoryList = await _categoryRepository.GetAllListAsync();
            var contentType = await _contentTypeRepository.GetAllListAsync();

            var cbtList = from ccl in cbtContentList
                        join cl in categoryList on ccl.CategoryId equals cl.Id
                        join ct in contentType on ccl.ContentTypeId equals ct.Id
                        join pccl in cbtContentList on ccl.PrecedingCBTContentId equals pccl.Id into pclE
                        from pccl in pclE.DefaultIfEmpty()
                        select new CBTContentDto
                        {
                            CBTContentId = ccl.Id,
                            PrecedingCBTContentId = ccl.PrecedingCBTContentId,
                            PrecedingCBTContentCode = pccl?.Code,
                            Code = ccl.Code,
                            Description = ccl.Description.Substring(0, ccl.Description.Length > 50 ? 50 : ccl.Description.Length) + (ccl.Description.Length > 50 ? "..." : ""),
                            Required = ccl.Required,
                            OnlyNumericValue = ccl.OnlyNumericValue,
                            IncludeComment = ccl.IncludeComment,
                            Comment = ccl.Comment,
                            AllowMultipleChoice = ccl.AllowMultipleChoice,
                            CategoryId = ccl.CategoryId,
                            CategoryName = cl.CategoryName,
                            ContentTypeId = ccl.ContentTypeId,
                            ContentName = ct.ContentName,
                            CBTContentOrder = ccl.CBTContentOrder
                        };

            return new ListResultDto<CBTContentDto>(
                ObjectMapper.Map<List<CBTContentDto>>(cbtList)
            );
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetCBTContentDDLItems()
        {
            var cbtContentList = await _cbtContentRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                cbtContentList.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Code + " - " + p.Description.Substring(0, p.Description.Length > 50 ? 50 : p.Description.Length) + (p.Description.Length > 50 ? "..." : ""))).ToList()
            );
        }

        //public async Task CreateCBTContent(CreateCBTContentInput input)
        //{
        //    var cbtContentList = ObjectMapper.Map<CBTContent>(input);
        //    await _cbtContentRepository.InsertAsync(cbtContentList);
        //}

        public async Task CreateCBTContent(string input)
        {
            try
            {
                CreateCBTContentInput cbtContent = JsonConversionHelper.ConvertFromJson<CreateCBTContentInput>(input);

                CBTContent cbt = new CBTContent();
                cbt.PrecedingCBTContentId = cbtContent.PrecedingCBTContentId;
                cbt.Code = cbtContent.Code;
                cbt.Description = cbtContent.Description;
                cbt.Required = cbtContent.Required;
                cbt.OnlyNumericValue = cbtContent.OnlyNumericValue;
                cbt.IncludeComment = cbtContent.IncludeComment;
                cbt.AllowMultipleChoice = cbtContent.AllowMultipleChoice;
                cbt.CategoryId = cbtContent.CategoryId;
                cbt.ContentTypeId = cbtContent.ContentTypeId;
                cbt.FileName = cbtContent.FileName;
                cbt.Location = cbtContent.Location;
                cbt.CBTContentOption = new List<CBTContentOptions>();

                for (int j = 0; j < cbtContent.CBTContentOption.Count(); j = j + 2)
                {
                    CBTContentOptions newOpt = new CBTContentOptions();
                    newOpt.OptionValue = cbtContent.CBTContentOption[j];
                    newOpt.DataType = cbtContent.CBTContentOption[j + 1];
                    cbt.CBTContentOption.Add(newOpt);
                }

                //var cbtContentList = ObjectMapper.Map<CBTContent>(cbt);
                await _cbtContentRepository.InsertAsync(cbt);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateCBTContent(UpdateCBTContentInput cbtContent)
        {
            try
            {
                List<int> options = new List<int>();
                var cbt = _cbtContentRepository.Get(cbtContent.CBTContentId);
                cbt.PrecedingCBTContentId = cbtContent.PrecedingCBTContentId;
                cbt.Code = cbtContent.Code;
                cbt.Description = cbtContent.Description;
                cbt.Required = cbtContent.Required;
                cbt.OnlyNumericValue = cbtContent.OnlyNumericValue;
                cbt.IncludeComment = cbtContent.IncludeComment;
                cbt.AllowMultipleChoice = cbtContent.AllowMultipleChoice;
                cbt.CategoryId = cbtContent.CategoryId;
                cbt.ContentTypeId = cbtContent.ContentTypeId;
                cbt.FileName = cbtContent.FileName;
                cbt.Location = cbtContent.Location;
                cbt.CBTContentOption = new List<CBTContentOptions>();

                options = _cbtContentOptionsRepository.GetAll().Where(o => o.CBTContent.Id == cbtContent.CBTContentId).Select(i => i.Id).ToList();
                for (int i = 0; i < cbtContent.CBTContentOption.Count(); i = i + 3)
                {
                    var index = options.FindIndex(a => a.Equals(Convert.ToInt32(cbtContent.CBTContentOption[i])));
                    options.RemoveAt(index);
                }

                for (int k = 0; k < options.Count(); k++)
                {
                    var delOpts = _cbtContentOptionsRepository.Get(Convert.ToInt32(options[k]));
                    _cbtContentOptionsRepository.Delete(delOpts);
                }

                for (int j = 0; j < cbtContent.CBTContentOption.Count(); j = j + 3)
                {
                    CBTContentOptions newOpt = new CBTContentOptions();

                    if (cbtContent.CBTContentOption[j] != "")
                    {
                        newOpt = _cbtContentOptionsRepository.Get(Convert.ToInt32(cbtContent.CBTContentOption[j]));
                    }
                    newOpt.OptionValue = cbtContent.CBTContentOption[j + 1];
                    newOpt.DataType = cbtContent.CBTContentOption[j + 2];

                    cbt.CBTContentOption.Add(newOpt);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public async Task DeleteCBTContent(int id)
        {
            var cbtContentList = await _cbtContentRepository
                            .GetAll()
                            .Where(p => p.Id == id)
                            .ToListAsync();

            if (cbtContentList.Count > 0)
            {
                await _cbtContentRepository.DeleteAsync(cbtContentList.FirstOrDefault());
            }
        }

        public CBTContentDto GetCBTContentById(int cbtContentId)
        {
            var cbtContent = _cbtContentRepository
                                    .GetAll()
                                    .Include(p => p.Categories)
                                    .Include(c => c.ContentType)
                                    .Include(c => c.CBTContentOption)
                                    .Where(p => p.Id == cbtContentId).FirstOrDefault();
            var cbtContentList = ObjectMapper.Map<CBTContentDto>(cbtContent);
            return cbtContentList;
        }

        public async Task<ListResultDto<CBTContentOptionsDto>> GetCBTContentOptionsList()
        {
            var cbtContentOptionsList = await _cbtContentOptionsRepository
                            .GetAll()
                            .ToListAsync();

            return new ListResultDto<CBTContentOptionsDto>(
                ObjectMapper.Map<List<CBTContentOptionsDto>>(cbtContentOptionsList)
            );
        }

        public async Task<ListResultDto<CategoryDto>> GetCategoryListByProgramId(GetCategoryListInput input)
        {
            try
            {
                var categoryList = await _categoryRepository
                                .GetAll()
                                .Include(t => t.PList)
                                .Include(t => t.CBTContents)
                                .Where(p => p.ProgramListId == input.ProgramListId)
                                .ToListAsync();

                return new ListResultDto<CategoryDto>(
                    ObjectMapper.Map<List<CategoryDto>>(categoryList)
                );
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<CBTContentDto>>  GetCBTContentByCategoryId(int catId)
        {
            var cbtContent = await _cbtContentRepository
                                    .GetAll()
                                    .Include(p => p.Categories)
                                    .Include(c => c.ContentType)
                                    .Include(c => c.CBTContentOption)
                                    .Where(p => p.CategoryId == catId)
                                    .ToListAsync();

            return new List<CBTContentDto>(
                ObjectMapper.Map<List<CBTContentDto>>(cbtContent)
            );
        }

        public List<ComboboxItemDto> GetCBTContentDDLItemsByCategoryId(int CategoryID)
        {
            var cbtContentList = _cbtContentRepository.GetAllList().Where(C=> C.CategoryId == CategoryID);
            return new List<ComboboxItemDto>(
                cbtContentList.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Code + " - " + p.Description.Substring(0, p.Description.Length > 50 ? 50 : p.Description.Length) + (p.Description.Length > 50 ? "..." : ""))).ToList()
            );
        }
    }
}
