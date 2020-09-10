using AMDAuto.DataAccess.Base;
using AMDAuto.Entities;
using AMDAuto.Entities.Views;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMDAuto.DataAccess.UnitOfWork
{
    public class AMDAutoUnitOfWork :  BaseUnitOfWork
    {
        public AMDAutoUnitOfWork(AmdautoContext context)
            :base(context)
        {

        }

        private IRepository<VwMostOperations> mostOperations;
        public IRepository<VwMostClients> mostClients { get; set; }
        public IRepository<VwMostCarParts> mostCarParts { get; set; }
        private IRepository<Users> users;
        private IRepository<Cars> cars;
        private IRepository<MakeNames> makes;
        private IRepository<ModelNames> models;
        private IRepository<Categories> categories;
        private IRepository<Operations> operations;
        private IRepository<Appointments> appointments;
        private IRepository<Photos> photos;
        private IRepository<Reviews> reviews;
        private IRepository<CarParts> carParts;
        private IRepository<CarPartsUsage> carPartsUsage;
        private IRepository<PastAppointments> pastAppointments;
        private IRepository<Comments> comments;
        private IRepository<Employees> employees;

        public IRepository<VwMostOperations> MostOperations
        {
            get
            {
                if (mostOperations == null)
                    mostOperations = new BaseRepository<VwMostOperations>(DbContext, true);
                return mostOperations;

            }
        }

        public IRepository<VwMostClients> MostClients
        {
            get
            {
                if (mostClients == null)
                    mostClients = new BaseRepository<VwMostClients>(DbContext, true);
                return mostClients;

            }
        }

        public IRepository<VwMostCarParts> MostCarParts
        {
            get
            {
                if (mostCarParts == null)
                    mostCarParts = new BaseRepository<VwMostCarParts>(DbContext, true);
                return mostCarParts;

            }
        }

        public IRepository<Users> Users
        {
            get
            {
                if (users == null)
                    users = new BaseRepository<Users>(DbContext);

                return users;
            }
        }

        public IRepository<Cars> Cars
        {
            get
            {
                if(cars == null)
                {
                    cars = new BaseRepository<Cars>(DbContext);
                }

                return cars;
            }
        }

        public IRepository<MakeNames> Makes
        {
            get
            {
                if(makes == null)
                {
                    makes = new BaseRepository<MakeNames>(DbContext);
                }
                return makes;
            }
        }

        public IRepository<ModelNames> Models
        {
            get
            {
                if(models == null)
                {
                    models = new BaseRepository<ModelNames>(DbContext);
                }
                return models;
            }
        }

        public IRepository<Categories> Categories
        {
            get
            {
                if(categories == null)
                {
                    categories = new BaseRepository<Categories>(DbContext);
                }
                return categories;
            }
        }
        public IRepository<Operations> Operations
        {
            get
            {
                if(operations == null)
                {
                    operations = new BaseRepository<Operations>(DbContext);
                }
                return operations;
            }
           
        }

        public IRepository<Appointments> Appointments
        {
            get
            {
                if (appointments == null)
                    appointments = new BaseRepository<Appointments>(DbContext);

                return appointments;
            }
        }

        public IRepository<Photos> Photos
        {
            get
            {
                if (photos == null)
                    photos = new BaseRepository<Photos>(DbContext);

                return photos;
            }
        }

        public IRepository<Reviews> Reviews
        {
            get
            {
                if (reviews == null)
                    reviews = new BaseRepository<Reviews>(DbContext);

                return reviews;
            }
        }

        public IRepository<CarParts> CarParts
        {
            get
            {
                if (carParts == null)
                    carParts = new BaseRepository<CarParts>(DbContext);

                return carParts;
            }
        }

        public IRepository<CarPartsUsage> CarPartsUsage
        {
            get
            {
                if (carPartsUsage == null)
                    carPartsUsage = new BaseRepository<CarPartsUsage>(DbContext);

                return carPartsUsage;
            }
        }

        public IRepository<PastAppointments> PastAppointments{
            get
            {
                if(pastAppointments == null)
                {
                    pastAppointments = new BaseRepository<PastAppointments>(DbContext);
                }
                return pastAppointments;
            }
        }
        public IRepository<Comments> Comments
        {
            get
            {
                if (comments == null)
                {
                    comments = new BaseRepository<Comments>(DbContext);
                }
                return comments;
            }
        }

        public IRepository<Employees> Employees
        {
            get
            {
                if(employees == null)
                {
                    employees = new BaseRepository<Employees>(DbContext);
                }
                return employees;
            }
        }

    }
}
