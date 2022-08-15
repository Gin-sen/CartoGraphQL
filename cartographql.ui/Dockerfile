FROM node:18-alpine
EXPOSE 3000

WORKDIR /app
COPY cartographql.ui/package*.json .
COPY cartographql.ui/tsconfig*.json .
COPY cartographql.ui/vite*.json .
# Install packages
RUN set -eux; \
    # Packages to install
    # apk add --no-cache git \
    npm install -g vite; \
    npm install
COPY cartographql.ui/ .
CMD ["npm","run", "dev"]