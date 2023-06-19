ARG VARIANT="6.0-bullseye"
FROM mcr.microsoft.com/vscode/devcontainers/dotnet:0-${VARIANT}

ARG NODE_VERSION="none"
RUN if [ "${NODE_VERSION}" != "none" ]; then su root -c "umask 0002 && . /usr/local/share/nvm/nvm.sh && nvm install ${NODE_VERSION} 2>&1"; fi

ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet tool install -g dotnet-ef --version 7.0.0

RUN npm i -g @angular/cli

RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends libnss3-tools

RUN su root -c "source /usr/local/share/nvm/nvm.sh && npm install -g @angular/cli" 2>&1