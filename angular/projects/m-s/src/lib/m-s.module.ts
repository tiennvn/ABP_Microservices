import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { MSComponent } from './components/m-s.component';
import { MSRoutingModule } from './m-s-routing.module';

@NgModule({
  declarations: [MSComponent],
  imports: [CoreModule, ThemeSharedModule, MSRoutingModule],
  exports: [MSComponent],
})
export class MSModule {
  static forChild(): ModuleWithProviders<MSModule> {
    return {
      ngModule: MSModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<MSModule> {
    return new LazyModuleFactory(MSModule.forChild());
  }
}
