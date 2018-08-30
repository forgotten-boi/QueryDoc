using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CBT.OnlineTutor.EClass;
using CBT.OnlineTutor.EClass.Dtos;
using CBT.OnlineTutor.Web.Models;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using CBT.OnlineTutor.ContentType;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using System.IO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CBT.OnlineTutor.Web.Controllers
{
    public class EClassController : OnlineTutorControllerBase
    {
        private readonly IEClassAppService _eClassAppService;
        private readonly IContentTypeAppService _contentTypeAppService;
        private IHostingEnvironment hostingEnv;

        public EClassController(IEClassAppService eClassAppService, IContentTypeAppService contentTypeAppService, IHostingEnvironment env)
        {
            _eClassAppService = eClassAppService;
            _contentTypeAppService = contentTypeAppService;
            hostingEnv = env;
        }

        public async Task<ActionResult> Index(GetProgramListInput input)
        {
            var output = await _eClassAppService.GetProgramList(input);
            var model = new ProgramListViewModel(output.Items);
            
            return View("ProgramList", model);
        }

        public async Task<ActionResult> CreateProgram()
        {
            var userTypeSelectListItems = (await _eClassAppService.GetUserTypeDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            userTypeSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            var programTypeSelectListItems = (await _eClassAppService.GetProgramTypeDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            programTypeSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            return View("CreateProgram", new CreateProgramViewModel(userTypeSelectListItems, programTypeSelectListItems));
        }

        //public async Task<ActionResult> DeleteProgram(int id)
        //{
        //    if(id == 0)
        //    {
        //        return View("ProgramList");
        //    }

        //    var pList = await _eClassAppService.Delete(id);
        //    var model = new ProgramListViewModel(pList.Items);
        //    return View("ProgramList", model);
        //}

        public async Task<ActionResult> UpdateProgram(int id)
        {
            var pList = _eClassAppService.GetProgramById(id);

            var userTypeSelectListItems = (await _eClassAppService.GetUserTypeDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            userTypeSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            var programTypeSelectListItems = (await _eClassAppService.GetProgramTypeDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            programTypeSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            CreateProgramViewModel cpVM = new CreateProgramViewModel(userTypeSelectListItems, programTypeSelectListItems);
            cpVM.ProgramId = pList.Id;
            cpVM.UniqueId = pList.UniqueId;
            cpVM.Name = pList.Name;
            cpVM.Description = pList.Description;
            cpVM.Status = pList.Status;
            cpVM.ProgramLastDate = pList.ProgramLastDate;
            cpVM.UserTypeId = pList.UserTypeId;
            cpVM.ProgramTypeId = pList.ProgramTypeId;

            return View("UpdateProgram", cpVM);
        }

        public async Task<ActionResult> CategoryList(GetCategoryListInput input)
        {
            var output = await _eClassAppService.GetCategoryList(input);
            var model = new CategoryListViewModel(output.Items);

            return View("CategoryList", model);
        }

        public async Task<ActionResult> CreateCategory()
        {
            var categorySelectListItems = (await _eClassAppService.GetCategoryDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            categorySelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            var programSelectListItems = (await _eClassAppService.GeProgramDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            programSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            return View("CreateCategory", new CreateCategoryViewModel(categorySelectListItems, programSelectListItems));
        }

        public async Task<ActionResult> UpdateCategory(int id)
        {
            var cList = _eClassAppService.GetCategoryById(id);

            var categorySelectListItems = (await _eClassAppService.GetCategoryDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            categorySelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            var programSelectListItems = (await _eClassAppService.GeProgramDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            programSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            CreateCategoryViewModel cVM = new CreateCategoryViewModel(categorySelectListItems, programSelectListItems);
            cVM.CategoryId = cList.Id;
            cVM.CategoryName = cList.CategoryName;
            cVM.Description = cList.Description;
            cVM.ParentId = cList.ParentId;
            cVM.ProgramListId = cList.ProgramListId;

            return View("UpdateCategory", cVM);
        }

        public async Task<ActionResult> CBTContentList(GetCBTContentListInput input)
        {
            var output = await _eClassAppService.GetCBTContentList(input);
            var model = new CBTContentListViewModel(output.Items);

            return View("CBTContentList", model);
        }

        public async Task<ActionResult> CreateCBTContent()
        {
            var categorySelectListItems = (await _eClassAppService.GetCategoryDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            categorySelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            var cbtContentSelectListItems = (await _eClassAppService.GetCBTContentDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            cbtContentSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            var contentTypeSelectListItems = (await _contentTypeAppService.GetContentTypeDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            contentTypeSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            CreateCBTContentViewModel cbtVM = new CreateCBTContentViewModel(categorySelectListItems, contentTypeSelectListItems, cbtContentSelectListItems);

            return View("CreateCBTContent", cbtVM);
        }

        public JsonResult GetCBTContentByCategoryId(int CategoryID)
        {
            var cbtContentSelectListItems = (_eClassAppService.GetCBTContentDDLItemsByCategoryId(CategoryID))
                .Select(p => p.ToSelectListItem())
                .ToList();

            cbtContentSelectListItems.Insert(0, new SelectListItem { Value = "0", Text = L("DEFAULTSELECT"), Selected = true });

            return Json(new SelectList(cbtContentSelectListItems, "Value", "Text"));
        }

        //[HttpPost]
        //public async Task<ActionResult> CreateContent(string input, List<IFormFile> files)
        //{
        //    CreateCBTContentInput cbtContent = JsonConversionHelper.ConvertFromJson<CreateCBTContentInput>(input);

        //    CBTContent cbt = new CBTContent();
        //    cbt.PrecedingCBTContentId = cbtContent.PrecedingCBTContentId;
        //    cbt.Code = cbtContent.Code;
        //    cbt.Description = cbtContent.Description;
        //    cbt.Required = cbtContent.Required;
        //    cbt.OnlyNumericValue = cbtContent.OnlyNumericValue;
        //    cbt.IncludeComment = cbtContent.IncludeComment;
        //    cbt.AllowMultipleChoice = cbtContent.AllowMultipleChoice;
        //    cbt.CategoryId = cbtContent.CategoryId;
        //    cbt.ContentTypeId = cbtContent.ContentTypeId;
        //    cbt.CBTContentOption = new List<CBTContentOptions>();

        //    for (int j = 0; j < cbtContent.CBTContentOption.Count(); j = j + 2)
        //    {
        //        CBTContentOptions newOpt = new CBTContentOptions();
        //        newOpt.OptionValue = cbtContent.CBTContentOption[j];
        //        newOpt.DataType = cbtContent.CBTContentOption[j + 1];
        //        cbt.CBTContentOption.Add(newOpt);
        //    }

        //    GetCBTContentListInput inp = new GetCBTContentListInput();
        //    var output = await _eClassAppService.GetCBTContentList(inp);
        //    var model = new CBTContentListViewModel(output.Items);

        //    return View("CBTContentList", model);
        //}
        public async Task<ActionResult> UpdateCBTContent(int id)
        {
            var cbtContentList = _eClassAppService.GetCBTContentById(id);

            var categorySelectListItems = (await _eClassAppService.GetCategoryDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            categorySelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            var cbtContentSelectListItems = (_eClassAppService.GetCBTContentDDLItemsByCategoryId(cbtContentList.CategoryId))
                .Select(p => p.ToSelectListItem())
                .Where(p => p.Value != cbtContentList.Id.ToString())
                .ToList();

            cbtContentSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            var contentTypeSelectListItems = (await _contentTypeAppService.GetContentTypeDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            contentTypeSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            CreateCBTContentViewModel cbtVM = new CreateCBTContentViewModel(categorySelectListItems, contentTypeSelectListItems, cbtContentSelectListItems);
            cbtVM.CBTContentId = cbtContentList.Id;
            cbtVM.PrecedingCBTContentId = cbtContentList.PrecedingCBTContentId;
            cbtVM.Code = cbtContentList.Code;
            cbtVM.Description = cbtContentList.Description;
            cbtVM.Required = cbtContentList.Required;
            cbtVM.OnlyNumericValue = cbtContentList.OnlyNumericValue;
            cbtVM.IncludeComment = cbtContentList.IncludeComment;
            cbtVM.Comment = cbtContentList.Comment;
            cbtVM.AllowMultipleChoice = cbtContentList.AllowMultipleChoice;
            cbtVM.CategoryId = cbtContentList.CategoryId;
            cbtVM.ContentTypeId = cbtContentList.ContentTypeId;
            cbtVM.CBTContentOrder = cbtContentList.CBTContentOrder;
            cbtVM.FileName = cbtContentList.FileName;
            cbtVM.Location = cbtContentList.Location;

            var cbtCL = cbtContentList.CBTContentOption.Select(x => new CBTContentOptionViewModel { CBTContentOptionId = x.Id, OptionValue = x.OptionValue, DataType = x.DataType }).ToList();
            cbtVM.CBTContentOption = cbtCL;
            ViewBag.Options = cbtCL;

            return View("UpdateCBTContent", cbtVM);
        }

        [HttpPost]
        public IActionResult UploadDocument()
        {
            var filePath = "";
            string newFileName = "";
            long size = 0;
            var files = Request.Form.Files;
            foreach (var file in files)
            {
                Guid id = Guid.NewGuid();
                var filename = ContentDispositionHeaderValue
                                .Parse(file.ContentDisposition)
                                .FileName
                                .Trim().ToString();
                
                newFileName = id + $@"_{ filename}";
                filename = hostingEnv.WebRootPath + $@"\UploadedFiles\{newFileName}";
                filePath = filename;
                size += file.Length;
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }
            //string message = filePath;
            //$"{files.Count} file(s) / { size} bytes uploaded successfully!";
            //return Json(message);
            return Json(new { Result = true, FilePath = filePath, FileName = newFileName });
        }
    }
}
