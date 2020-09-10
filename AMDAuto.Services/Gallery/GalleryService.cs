using AMDAuto.DataAccess.UnitOfWork;
using AMDAuto.Entities;
using AMDAuto.Entities.DTOs;
using AMDAuto.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMDAuto.Services.Gallery
{
    public class GalleryService : BaseService
    {
        private readonly CurrentUser currentUser;

        public GalleryService(AMDAutoUnitOfWork unitOfWork, CurrentUser currentUser)
            : base(unitOfWork)
        {
            this.currentUser = currentUser;
        }

        public bool Add(Photos photo)
        {
            photo.Id = Guid.NewGuid();
            UnitOfWork.Photos.Add(photo);

            return UnitOfWork.SaveChanges();
        }

        public Photos GetPhotoById(Guid id)
        {
            return UnitOfWork.Photos.Query.FirstOrDefault(p => p.Id == id);
        }

        public List<Photos> GetPhotos()
        {
            return UnitOfWork.Photos.Query.ToList();
        }

        public bool DeletePhoto(Guid id)
        {
            var photo = UnitOfWork.Photos.Query.FirstOrDefault(p => p.Id == id);
            if(photo != null)
            {
                UnitOfWork.Photos.Remove(photo);
            }
            return UnitOfWork.SaveChanges();
        }
    }
}
