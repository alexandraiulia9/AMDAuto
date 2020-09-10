using AMDAuto.Code.Base;
using AMDAuto.Entities;
using AMDAuto.Entities.DTOs;
using AMDAuto.Models;
using AMDAuto.Services.Gallery;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly GalleryService galleryService;
        private readonly CurrentUser currentUser;
        public GalleryController(GalleryService galleryService, CurrentUser currentUser, IMapper mapper) : base(mapper)
        {
            this.galleryService = galleryService;
            this.currentUser = currentUser;
        }

        public IActionResult Gallery()
        {
            ViewData["Message"] = "Galerie cu poze";
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddPhoto(AddPhotoVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var entity = mapper.Map<Photos>(model);

            var result = galleryService.Add(entity);

            if (!result)
                return InternalServerErrorView();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetPhotoById(Guid id)
        {
            var result = galleryService.GetPhotoById(id);
            if (result == null)
                return NotFoundView();

            var bytes = result.Content;
            return File(bytes, "image/jpg");
        }

        [HttpGet]
        public IActionResult EditPhotos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeletePhoto(Guid id)
        {
            var result = galleryService.DeletePhoto(id);
            if (!result)
            {
                return InternalServerErrorView();
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult GetPhotos()
        {
            var result = galleryService.GetPhotos();

            var entities = result.Select(u => mapper.Map<PhotoVM>(u)).ToList();

            return Json(entities);
        }

        [HttpGet]
        public IActionResult ViewGallery()
        {
            var model = new GalleryVM();
            model.Photos = GetPhotosForCarousel();
            model.NumberOfPhotos = model.Photos.Count;

            return View(model);
        }

        [NonAction]
        private List<PhotoVM> GetPhotosForCarousel()
        {
            var entities = galleryService.GetPhotos();
            var result = entities.Select(u => mapper.Map<PhotoVM>(u)).ToList();

            return result;
        }
    }
}
