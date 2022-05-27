import { ModuleWithProviders, NgModule } from '@angular/core';
import { MS_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class MSConfigModule {
  static forRoot(): ModuleWithProviders<MSConfigModule> {
    return {
      ngModule: MSConfigModule,
      providers: [MS_ROUTE_PROVIDERS],
    };
  }
}
