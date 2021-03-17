﻿using AutoMapper;
using BeautyAtHome.ViewModels;
using Infrastructure.Contexts;
using System.Collections.Generic;

namespace BeautyAtHome.Utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region AutoMapper ServiceViewModel
            CreateMap<ServiceCM, Service>();
            CreateMap<Service, ServiceVM>();
            CreateMap<Service, ServicePagingSM>();
            CreateMap<ServicePagingSM, Service>();
            CreateMap<ServiceVM, Service>();
            CreateMap<ServiceCM, Service>();
            #endregion

            #region AutoMapper AccountViewModel
            CreateMap<Account, AccountPagingSM>();
            #endregion

            #region AutoMapper GalleryViewModel
            CreateMap<Gallery, GalleryPagingSM>();
            CreateMap<Gallery, GalleryVM>();
            CreateMap<GalleryCM, Gallery>();
            #endregion

            #region AutoMapper ImageViewModel
            /*CreateMap<ICollection<Image>, ImagesPagingSM>();*/
            CreateMap<Image, ImageDefaultPagingSM>();
            CreateMap<ImageCM, Image>();
            CreateMap<Image, ImageVM>();
            #endregion

            #region AutoMapper ServiceTypeViewModel
            CreateMap<ServiceType, ServiceTypePagingSM>();
            CreateMap<ServiceTypeCM, ServiceType>();
            CreateMap<ServiceType, ServiceTypeVM>();
            #endregion

            #region
            CreateMap<FeedBack, FeedBackVM>();
            CreateMap<FeedBackCM, FeedBack>();
            CreateMap<FeedBackVM, FeedBack>();
            #endregion

            #region
            CreateMap<Booking, BookingVM>();
            CreateMap<BookingCM, Booking>();
            #endregion

            #region
            CreateMap<BookingDetail, BookingDetailVM>();
            CreateMap<BookingDetailCM, BookingDetail>();
            #endregion

            #region AutoMapper AddressViewModel
            CreateMap<AddressCM, Address>();
            CreateMap<Address, AddressVM>();
            #endregion

            #region AutoMapper AccountViewModel
            CreateMap<AccountCM, Account>();
            CreateMap<Account, AccountVM>();
            #endregion
        }
    }
}
