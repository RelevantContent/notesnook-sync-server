# Notesnook Sync Server

This repo contains the full source code of the Notesnook Sync Server licensed under AGPLv3.

## Building

Requirements:

1. [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
2. [git](https://git-scm.com/downloads)

The first step is to `clone` the repository:

```bash
git clone https://github.com/streetwriters/notesnook-sync-server.git

# change directory
cd notesnook-sync-server
```

Once you are inside the `./notesnook-sync-server` directory, run:

```bash
# this might take a while to complete
dotnet restore Notesnook.sln
```

Then build the Notesnook.API project:

```bash
dotnet build Notesnook.API/Notesnook.API.csproj
```

## TODO Self-hosting

**Note: Self-hosting the Notesnook Sync Server is not yet possible. We are working to enable full on-premise self hosting so stay tuned!**

- [ ] Open source the Identity server
- [ ] Open source the SSE Messaging infrastructure
- [ ] Fully Dockerize all services
- [ ] Publish on DockerHub
- [ ] Write self hosting docs

## License

```
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
```
