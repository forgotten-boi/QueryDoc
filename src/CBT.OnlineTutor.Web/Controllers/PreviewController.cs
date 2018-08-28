using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CBT.OnlineTutor.EClass;
using CBT.OnlineTutor.Web.Models;
using CBT.OnlineTutor.EClass.Dtos;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CBT.OnlineTutor.Web.Controllers
{
    public class PreviewController : OnlineTutorControllerBase
    {
        private readonly IEClassAppService _eClassAppService;

        public PreviewController(IEClassAppService eClassAppService)
        {
            _eClassAppService = eClassAppService;
        }

        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            GetCategoryListInput input = new GetCategoryListInput();
            input.ProgramListId = 0;

            var output = await _eClassAppService.GetCategoryListByProgramId(input);

            //var program = _eClassAppService.GetProgramById(input.ProgramListId);

            //if (program != null)
            //{
            //    ViewBag.UniqueId = program.UniqueId;
            //    ViewBag.Name = program.Name;
            //    ViewBag.Description = program.Description;
            //}

            //List<CBTContentDto> cbtContentList = new List<CBTContentDto>();

            //foreach (var cat in output.Items)
            //{
            //    var contentByCategoryId = await _eClassAppService.GetCBTContentByCategoryId(cat.Id);
            //    cbtContentList.AddRange(contentByCategoryId);
            //}
            //cbtContentList = cbtContentList.ToList();

            var programSelectListItems = (await _eClassAppService.GeProgramDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            programSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            CategoryListViewModel clVM = new CategoryListViewModel(output.Items);
            //clVM.CBTContentLists = cbtContentList;
            clVM.ProgramList = programSelectListItems;

            return View("PreviewCBT", clVM);
        }

        public async Task<PartialViewResult> GetContentDetail(int programId)
        {
            string viewName = "PreviewDetail";
            GetCategoryListInput input = new GetCategoryListInput();
            input.ProgramListId = programId;

            var output = await _eClassAppService.GetCategoryListByProgramId(input);

            var program = _eClassAppService.GetProgramById(input.ProgramListId);

            if (program != null)
            {
                ViewBag.UniqueId = program.UniqueId;
                ViewBag.Name = program.Name;
                ViewBag.Description = program.Description;

                if (program.ProgramTypeId == 1)
                {
                    ViewBag.ProgramType = "Training";
                }
                else if (program.ProgramTypeId == 2)
                {
                    ViewBag.ProgramType = "Survey";
                }
            }

            if (program.ProgramTypeId == 1)
            {
                viewName = "PreviewTraining";
            }
            else if (program.ProgramTypeId == 2)
            {
                viewName = "PreviewDetail";
            }

            List<CBTContentDto> cbtContentList = new List<CBTContentDto>();

            foreach (var cat in output.Items)
            {
                var contentByCategoryId = await _eClassAppService.GetCBTContentByCategoryId(cat.Id);
                cbtContentList.AddRange(contentByCategoryId);
            }
            cbtContentList = cbtContentList.ToList();

            var programSelectListItems = (await _eClassAppService.GeProgramDDLItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            programSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("DEFAULTSELECT"), Selected = true });

            CategoryListViewModel clVM = new CategoryListViewModel(output.Items);
            clVM.CBTContentLists = cbtContentList;
            clVM.ProgramList = programSelectListItems;
            clVM.ProgramListId = programId;

            return PartialView(viewName, clVM);
        }
    }
}
