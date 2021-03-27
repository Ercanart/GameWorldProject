using GameWorldProject.PropertyClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.İnterfaces
{
    interface ICampignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
