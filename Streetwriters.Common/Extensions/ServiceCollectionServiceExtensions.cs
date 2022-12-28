/*
This file is part of the Notesnook Sync Server project (https://notesnook.com/)

Copyright (C) 2022 Streetwriters (Private) Limited

This program is free software: you can redistribute it and/or modify
it under the terms of the Affero GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
Affero GNU General Public License for more details.

You should have received a copy of the Affero GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace Microsoft.Extensions.DependencyInjection.CorsServiceCollectionExtensions
{
    public static class ServiceCollectionServiceExtensions
    {
        public static IServiceCollection AddCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("notesnook", (b) =>
                {
#if DEBUG
                    b.AllowAnyOrigin();
#else
                    b.WithOrigins("http://localhost:3000", "http://192.168.10.29:3000", "https://app.notesnook.com", "https://beta.notesnook.com", "https://budi.streetwriters.co", "http://localhost:9876");
#endif
                    b.AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();
                });
            });
            return services;
        }
    }
}
